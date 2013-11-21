using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KeyGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox.Text = "key.txt";
        }

        private void button_generate_key_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[] array = new int[26];
            string key = "";

            for (byte i = 0; i < 26; ++i)
            {
                array[i] = rand.Next(10, 100);
                for (byte j = 0; j < i; ++j)
                    if (array[j] == array[i])
                    {
                        j = 0;
                        array[i] = rand.Next(10, 100);
                    }
                key += array[i];
                key += ' ';
            }

            try
            {
                StreamWriter sw = new StreamWriter(textBox.Text);
                sw.Write(key);
                sw.Close();
                MessageBox.Show("Success!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Could not overwrite " + textBox.Text + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = openFileDialog.FileName;
            }
        }
    }
}
