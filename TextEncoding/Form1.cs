using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TextEncoding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Regular_Text.Text == "")
            {
                MessageBox.Show("Textbox is empty!", "Wrong input", MessageBoxButtons.OK);
                return;
            }
            else
            {
                TextEncryptor textEncryptor;
                if (Password.Text == "")
                {
                    MessageBox.Show("Password is empty!", "Wrong input", MessageBoxButtons.OK); 
                    return;
                }
                switch (Method.Text)
                {
                    case "Vigenere cipher":
                        textEncryptor = new VigenereCipher();                        
                        break;
                    case "Vernam cipher":
                        textEncryptor = new VernamCipher();                        
                        break;
                    case "Transposition cipher":
                        try
                        {
                            int key = Int32.Parse(Password.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Transposition password must be a positive integer!", "Wrong input", MessageBoxButtons.OK);
                            return;
                        }
                        textEncryptor = new TranspositionCipher();
                        break;
                    default:
                        MessageBox.Show("Choose encrypting method!", "Wrong input", MessageBoxButtons.OK);
                        return;
                        break;
                }
                try
                {
                    Encrypted_Text.Text = textEncryptor.Encrypt(Regular_Text.Text, Password.Text);
                }
                catch
                {
                    MessageBox.Show("Encryption failed, try using another method!", "Wrong input", MessageBoxButtons.OK);
                    return;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Encrypted_Text.Text == "")
            {
                MessageBox.Show("Encrypted text is empty!", "Wrong input", MessageBoxButtons.YesNo);
            }
            else
            {
                TextEncryptor textEncryptor;
                if (Password.Text == "")
                {
                    MessageBox.Show("Password is empty!", "Wrong input", MessageBoxButtons.OK);
                }
                switch (Method.Text)
                {
                    case "Vigenere cipher":
                        textEncryptor = new VigenereCipher();                        
                        break;
                    case "Vernam cipher":
                        textEncryptor = new VernamCipher();                        
                        break;
                    case "Transposition cipher":
                        try
                        {
                            int key = Int32.Parse(Password.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Transposition password must be a positive integer!", "Wrong input", MessageBoxButtons.OK);
                            return;
                        }
                        textEncryptor = new TranspositionCipher();
                        break;
                    default:
                        MessageBox.Show("Choose encrypting method!", "Wrong input", MessageBoxButtons.OK);
                        return;
                        break;
                }
                try
                {
                    Regular_Text.Text = textEncryptor.Decrypt(Encrypted_Text.Text, Password.Text);
                }
                catch
                {
                    MessageBox.Show("Decryption failed, message might use another method!", "Wrong input", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void encryptedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image files | *.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filename = dialog.FileName;
                File.WriteAllText(filename, Encrypted_Text.Text);
            }
        }

        private void plainTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image files | *.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filename = dialog.FileName;
                File.WriteAllText(filename, Regular_Text.Text);
            }
        }

        private void encryptedTextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str= File.ReadAllText(dialog.FileName);
                Encrypted_Text.Text = str;
            }
        }

        private void plainTextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = File.ReadAllText(dialog.FileName);
                Regular_Text.Text = str;
            }
        }
    }

}

