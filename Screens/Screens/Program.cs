using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screens
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
     public class ErrorSreens
    {
        public void FilePathError() 
        {
            Console.WriteLine("Error: Not a valid file path.");
        }
        public void InputTextError()
        {
            Console.WriteLine("Error: An error occured from the input text.");
        }
        public void RotorSelectionError()
        {
            Console.WriteLine("Error: not a valid rotor offset.");
        }
        public void GeneralError()
        {
            Console.WriteLine("Error: an error has occured.");
        }
    }
    public class Screens
    {
        public void Home_Screen() // first screen where users can choose what to do
        {
            Console.WriteLine("Welcome to enigma encryptor \n " +
                "To begin type \"start\" or type \"help\" for instructions.");
        }
        public void Encrypt_Decrypt_Screen() // keyboard input is inputed on this screen
        {
            Console.WriteLine("Are you encrypting or decrypting? \n" +
                "Type \"encrypt\" to encrypt, \"decrypt\" to decrypt");
        }
        public void Textbox_File_Screen() // keyboard input is inputed on this screen
        {
            Console.WriteLine("Would you like a text box to type or to upload a file? \n" +
                "Type \"textbox\" for text box, \"file\" for file");
        }
        public void Textbox_File_ScreenOut() // keyboard input is inputed on this screen
        {
            Console.WriteLine("Would you like to output to a text box or to a file? \n" +
                "Type \"textbox\" for text box, \"file\" for file");
        }
        public void File_Name_Screen() // keyboard input is inputed on this screen
        {
            Console.WriteLine("Please type the location of the file formated like drivename:\\Foldername\\Filename...");
        }
        public void File_Name_ScreenOut() // keyboard input is inputed on this screen
        {
            Console.WriteLine("Please type the location where you would like the file stored. Format like: drivename:\\Foldername\\Filename...");
        }
        public void New_File_Name_Screen() // keyboard input is inputed on this screen
        {
            Console.WriteLine("Please type the name of the new encrypted file.");
        }
        public void HelpScreen()  // instruction for the program
        {
            Console.WriteLine("Instructions \n" +
                "1. After typing start Select from the options menu if you want to encrypt or decrypt. \n" +
                "Encrypt:\n" +
                "2. Then from the options menu if you want to upload a file or type into the text box. \n" +
                "3. If you choose file upload please provide a file directory in the form of drivename:\\Foldername\\Filename...\n" +
                "4. If you choose textbox a prompt will tell you when to start typing. Finish typing by creating a new line\n" +
                "by pressing enter then enter ` and press enter\n" +
                "5. After finishing the encryption you can either have the text displayed as a file where you will need to provide a file path to save\n" +
                "in the same form as drivename:\\Foldername\\Filename...\n" +
                " if you choose textbox the text will appear. All of the following will have the rotor settings for decryption attached \n" +
                "Note! The rotor settings will lead to the decryption of your message. Make sure only those you want to read it have the keys \n" +
                "Decrypt: \n" +
                "6. If you choose to decrypt you will be prompted to enter the 4 rotor settings. provided with the encrypted message\n" +
                "7. Then you will be prompted if you would like textbox input or file input\n" +
                "7. If file upload was selected then please provide a file directory in the form of drivename:\\Foldername\\Filename...\n" +
                "8. If textbox was selected then a text box will appear \n" +
                " a prompt will tell you when to begin typing the message.\n" +
                "once finished create a new line by pressing enter then press ` and enter again to end transmition of message \n "+
                "9. You will be prompted if you want textbox ouput or file output, textbox output will just display the decrypted messaged\n" +
                "If file output is selected you will be promted to enter a file path in the form of drivename:\\Foldername\\Filename...\n" +
                "from a file upload will appear.\n");

        }
        public void AboutScreen()  // purpose of the program
        {
            Console.WriteLine("This program is an encrypter and was specially designed to keep your text safe from prying eyes. \n" +
                "This was developed as part of the cis220m class at Manchester Community College.\n" +
                "For more information on how to use this program see the help page.");
        }
        public void Rotor1_Screen() // where users can chose encrypt/decrypt and then set rotors
        {
            Console.WriteLine("Enter the prime number to set rotor 1.");
        }
        public void Rotor2_Screen() // where users can chose encrypt/decrypt and then set rotors
        {
            Console.WriteLine("Enter the prime number to set rotor 2.");
        }
        public void Rotor3_Screen() // where users can chose encrypt/decrypt and then set rotors
        {
            Console.WriteLine("Enter the prime number to set rotor 3.");
        }
        public void Rotor4_Screen() // where users can chose encrypt/decrypt and then set rotors
        {
            Console.WriteLine("Enter the prime number to set rotor 4.");
        }
        public void Textbox_Input_Screen() // where users can chose encrypt/decrypt and then set rotors
        {
            Console.WriteLine("Enter your text to be encrypted below.\n" + "once finished create a new line by pressing enter then press ` and enter again to end transmition of message");
        }
        public void Textbox_Input_ScreenOut() // where users can chose encrypt/decrypt and then set rotors
        {
            Console.WriteLine("Enter your text to be decrypted below.\n" + "once finished create a new line by pressing enter then press ` and enter again to end transmition of message");
        }
        public void Textbox_Output_Screen() // where users can chose encrypt/decrypt and then set rotors
        {
            Console.WriteLine("below is your encrypted text.");
        }
        public void File_Output_Screen(string newfilelocation) // where users can chose encrypt/decrypt and then set rotors
        {
            Console.WriteLine("Your text has been encrypted succesfully and is stored at [0].", newfilelocation);
        }

    }
}
