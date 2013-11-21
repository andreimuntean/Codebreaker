#include <algorithm>
#include <cstdlib>
#include <cstring>
#include <fstream>
#include <iostream>
#include <vector>

using namespace std;
vector<char> message;
vector<unsigned> spaces;
unsigned key[26];
char alphabet[26];
unsigned error = 0;

void Initialize()
{
    ifstream file("key.txt");
    for (unsigned i = 0;  i < 26;  ++i)
    {
        file >> key[i];
        alphabet[i] = '~';
    }
    file.close();

    file.open("message.txt");
    string word;
    vector<string> words;
    unsigned i = 0;
    char forbidden[] = "()-+,.;:!?*&^%$#@|/`'\"\\[]";
    while (!file.eof())
    {
        file >> word;

        for (unsigned int i = 0;  i < strlen(forbidden); ++i)
        {
            word.erase(remove(word.begin(), word.end(), forbidden[i]), word.end());
        }
        transform(word.begin(), word.end(), word.begin(), ::toupper);
        words.push_back(word);
        if (spaces.size() > 0) spaces.push_back(spaces[i-1] + word.size());
        else spaces.push_back(word.size());
        i++;
    }
    file.close();

    for (unsigned i = 0;  i < words.size();  ++i)
        for (unsigned j = 0;  j < words[i].size();  ++j)
            message.push_back(words[i][j]);
}

void PrintErrors()
{
    switch (error)
    {
        case 1: cout << "\n\nERROR: That letter is already being used."; break;
        case 2: cout << "\n\nERROR: Invalid input. Only letters may be used."; break;
        case 3: cout << "\n\nERROR: That number is not being used."; break;
        case 4: cout << "\n\nERROR: That letter is not being used."; break;
    }
}

void PrintLetter(int i)
{
    if (0 <= i && i <= 25)
    {
        if (alphabet[i] != '~')
            cout << ' ' << alphabet[i];
        else cout << key[i];
    }
    else cout << '_' << i + 17;
    cout << " ";
}

void Print()
{
    system("cls");
    bool space = false, newline = false;
    cout << "Codebreaker\n-----------\nProgrammed by Andrei Muntean\n\n";
    for (unsigned i = 0;  i < message.size();  ++i)
    {
        for (unsigned j = 0;  j < spaces.size();  ++j)
            if (i == spaces[j]) { space = true; break; }

        if (i % 16 == 0 && i > 0) newline = true;

        if (space)
        {
            if (newline) { cout << endl; newline = false; }
            else cout << "   ";
            space = false;
        }

        PrintLetter(message[i] - 65);
    }
    PrintErrors();
    error = 0;
    cout << "\n\nUse the following format to replace a number with a letter: <Number> <Letter>";
    cout << "\nOr use the following command to reset a letter: 0 <Letter>\n> ";
}

void Convert(unsigned number, char letter)
{
    if ((65 <= letter && letter <= 90) || (97 <= letter && letter <= 122))
    {
        if (97 <= letter) letter -= 32;
        for (unsigned i = 0;  i < 26;  ++i)
            if (key[i] == number)
            {
                for (unsigned j = 0;  j < 26;  ++j)
                    if (alphabet[j] == letter)
                    {
                        error = 1;
                        return;
                    }
                alphabet[i] = letter;
                return;
            }
    } else error = 2;
    error = 3;
}

void ResetLetter(char letter)
{
    if ((65 <= letter && letter <= 90) || (97 <= letter && letter <= 122))
    {
        if (97 <= letter) letter -= 32;
        for (unsigned i = 0;  i < 26;  ++i)
            if (alphabet[i] == letter)
            {
                alphabet[i] = '~';
                return;
            }
    } else error = 2;
    error = 4;
}

void Input()
{
    char letter;
    int number;
    cin >> number >> letter;
    if (letter != '~')
    {
        if (number >= 10) Convert(number, letter);
        else if (number == 0) ResetLetter(letter);
    }
}

int main()
{
    Initialize();
    while (true)
    {
        Print();
        Input();
    }
}
