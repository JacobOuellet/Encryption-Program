/* main menu for encryptor
 * By Jacob Ouellet
 * 10/22/17
 * version 0.0.1
 * This is the windows form applkication design for the main menue. It references the windows form help menu in additiontion
 * The purpose of this program is to provide a gui for th euser that collected information about the encrypt or decrypt process
 * it asks the user whether they are encrypting or decrypting, it also asks the user whether they want to type in a text box or uplaod a file. 
 * if they choose file it will promp them for an output file name and then have them choose a file to upload. If they choose to decrypt
 * it asks for the start point for the three rotors. There is also a hel button which opens the help window that has instruction for using the program. 
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using WindowsFormsApp3;
using Encrypt;
using Decrypt;
using Decrypt_Output;
using Output;
using Utilities;

namespace EncryptMainMenu
{
    public partial class Encrypter : Form
    {
        bool test = false;
        private string response;  // public variable used to store the new file name
        private string filename;
        private string OriginalFileName;
        public Encrypter()
        {
            InitializeComponent();
        }

        private void Decrypt_CheckedChanged(object sender, EventArgs e)
        {
            Rotor_Settings.Enabled = true;
            btn_encrypt.Enabled = false;
            btn_Decrypt.Enabled = false;
            if (test)
            {
                if (Text_Box.Checked || File_Upload.Checked)
                {
                    btn_Decrypt.Enabled = true;
                }
            }
        }

        private void Encrypt_CheckedChanged(object sender, EventArgs e)
        {
            Rotor_Settings.Enabled = false;
            btn_Decrypt.Enabled = false;
            btn_encrypt.Enabled = false;
            if (test)
            {
                if (Text_Box.Checked || File_Upload.Checked)
                {
                    btn_encrypt.Enabled = true;
                }
            }
            test = true;
        }

        private void File_Upload_CheckedChanged(object sender, EventArgs e)
        {
            File_Name.Enabled = true;
            Input_textbox.Enabled = false;
            response = null;
            btn_encrypt.Enabled = false;
            btn_Decrypt.Enabled = false;
            if (Decrypt.Checked)
            {
                btn_Decrypt.Enabled = true;
                btn_encrypt.Enabled = false;
            }
            else if (Encrypt.Checked)
            {
                btn_Decrypt.Enabled = false;
                btn_encrypt.Enabled = true;
            }

        }

        private void Text_Box_CheckedChanged(object sender, EventArgs e)
        {
            File_Name.Enabled = false;
            Input_textbox.Enabled = true;
            response = null;
            if (Decrypt.Checked)
            {
                btn_Decrypt.Enabled = true;
                btn_encrypt.Enabled = false;
            }
            else if (Encrypt.Checked)
            {
                btn_Decrypt.Enabled = false;
                btn_encrypt.Enabled = true;
            }
        }

        private void btn_submit_name_Click(object sender, EventArgs e)
        {
            response = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt (*.txt*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
            OriginalFileName = openFileDialog1.FileName;
            if (OriginalFileName.Contains(".txt") || OriginalFileName.Contains(".html"))
            {
                string line;
               try
                {
                    using (System.IO.StreamReader file = new System.IO.StreamReader(@OriginalFileName, true))
                    {
                        while ((line = file.ReadLine())!= null)
                        {
                            response += line;
                        }
                        file.Close();
                    }
                    filename = txtFile_Name_Text.Text;
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filename, true))
                    {
                        file.Close();
                    }
                    
                    if (Decrypt.Checked)
                    {
                            btn_Decrypt.Enabled = true;
                            btn_encrypt.Enabled = false;
                    }
                    else if (Encrypt.Checked)
                    {
                            btn_Decrypt.Enabled = false;
                            btn_encrypt.Enabled = true;
                    }
                    
                    else
                    {
                        response = null;
                        MessageBox.Show("Invalid file upload or new file directory! Please make sure the file is a text file or html type file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
                catch
                {
                    response = null;
                    MessageBox.Show("Invalid file upload or new file directory! Please make sure the file is a text file or html type file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                OriginalFileName = null;
                MessageBox.Show("Invalid file upload please upload .txt and .html files only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.Form1 Form2 = new WindowsFormsApp1.Form1();
            Form2.Show();                                                  // opens the help menu window
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            Output.Output output = new Output.Output();
            Encrypt.Encrypt encrypt = new Encrypt.Encrypt();
            Encrypt.EncryptedPackage package = new Encrypt.EncryptedPackage();
              if (File_Upload.Checked)                // if its a file upload it will pass the file name otherwise the file name is null
              {
                try
                {
                    package = encrypt.EncyptText(response);
                    output.Textorfile(package.text, package.key, "file", filename);
                    File.Delete(OriginalFileName);
                    response = null;
                    MessageBox.Show("Your text has been encrypted successfuly and the uploaded file has been deleted", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Your text has not been encrypted because an error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
              }
              else 
              {
                try
                {
                    response = Input_textbox.Text;
                    response = response.Replace("\r\n", null);
                    package = encrypt.EncyptText(response);
                    output.Textorfile(package.text, package.key, "textbox", null);
                }
                catch
                {
                    MessageBox.Show("Your text has not been encrypted because an error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              }                     
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            int count = 0;
            Decrypt.Decryption Decryption = new Decrypt.Decryption();
            Decrypt_Output.OutputDecrypt Output = new Decrypt_Output.OutputDecrypt();
            Utilities.PrimeCheck checkifprime = new Utilities.PrimeCheck();
            int rotor1, rotor2, rotor3, rotor4;



            rotor1 = int.Parse(comboBox1.Text);   // check for prime
            rotor2 = int.Parse(comboBox2.Text);
            rotor3 = int.Parse(comboBox3.Text);
            rotor4 = int.Parse(comboBox4.Text);

            if (checkifprime.IsPrime(rotor1) && checkifprime.IsPrime(rotor2) && checkifprime.IsPrime(rotor3) && checkifprime.IsPrime(rotor4))
            {
                try                  // gets rotor information if rotor is null the trry catch will catch the error
                {

                    if (File_Upload.Checked)
                    {
                        response = Decryption.DecryptText(response, rotor1, rotor2, rotor3, rotor4);
                        Output.Output("file", response, filename);
                        File.Delete(OriginalFileName);
                        MessageBox.Show("Your text has been decrypted successfuly and the uploaded file has been deleted", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        response = Input_textbox.Text;
                        response = response.Replace("\r\n", null);
                        response = Decryption.DecryptText(response, rotor1, rotor2, rotor3, rotor4);
                        Output.Output("textbox", response, filename);

                    }
                }
                catch
                {
                    if (count == 0)
                    {
                        count++;
                        btn_Decrypt_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Your text has not been decrypted because an error has occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("A rotor selection is empty or a non-prime number has not been entered" +
                    "\n Note! Prime numbers must be between 2-73", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Encrypter_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsFormsApp3.Form1 showabout = new WindowsFormsApp3.Form1();
            showabout.Show();
        }
    }
}
