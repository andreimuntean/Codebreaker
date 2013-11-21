namespace KeyGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_browse = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button_generate_key = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(178, 22);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(75, 23);
            this.button_browse.TabIndex = 0;
            this.button_browse.Text = "Browse...";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(6, 24);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(166, 20);
            this.textBox.TabIndex = 1;
            // 
            // button_generate_key
            // 
            this.button_generate_key.Location = new System.Drawing.Point(154, 77);
            this.button_generate_key.Name = "button_generate_key";
            this.button_generate_key.Size = new System.Drawing.Size(117, 28);
            this.button_generate_key.TabIndex = 2;
            this.button_generate_key.Text = "Generate Key";
            this.button_generate_key.UseVisualStyleBackColor = true;
            this.button_generate_key.Click += new System.EventHandler(this.button_generate_key_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox);
            this.groupBox1.Controls.Add(this.button_browse);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "message.txt";
            this.openFileDialog.Filter = "Text Documents|*.txt|All files|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 113);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_generate_key);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Key Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button_generate_key;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

