/*
 * Utilities package
 * Jacob Ouellet
 * CIS 220
 * 10/1/17
 * Version 0.0.1
 * Utilities package for the enigma project: Houses classes and methods that
 * don't fit into any of the other packages as they are mainly infrustructure 
 * for the program. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    // main utilities class
    public class Utilities
    {
        public void Menu(int value)
        {
            switch (value) // four case statments because the user should be able to 
            {              // select four possible screens as the other screens shoudl appear 
                           // automatically as part of the program
                case 1:   // case to go to the HomeScreen (ie they went a different screen so it can go back)
                    {
                        break;
                    }
                case 2:   // screen to go to the help screen
                    {
                        break;
                    }
                case 3:     // screen to go to the about screen
                    {
                        break;
                    }
                case 4:    // screen to go to the exit screen
                    {
                        break;
                    }
                
            }
        }
    }
    // rotor configurartion class
    public class Config
    {
        public void GetRotor1()
        {

        }
        public void GetRotor1Position()
        {

        }
        public void GetRotor2()
        {

        }
        public void GetRotor2Position()
        {

        }
        public void GetRotor3()
        {

        }
        public void GetRotor3Position()
        {

        }
        public void FileOrKeyboard()
        {

        }
        public void GetFilePath()
        {

        }
        public void DeleteFile()
        {

        }
        public void SetOutPutFilePath()
        {

        }
    }
    // return class to restart or return to a specific point in the program
    // if an error occurs
    public class Return
    {
        public void FilePathReturn()
        {

        }
        public void RotorSelectionReturn()
        {

        }
        public void ProgramRestart()
        {

        }
        public void ProgramExit()
        {

        }
    }
    public class Logfile
    {
        public void Log(string methodname, string classname, int line, int count)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"J:\TestFile\log.txt", true))
                if (count == 1)
                {
                    file.WriteLine("Started method {0} in class {1} at line {2}", methodname, classname, line);
                    return;
                }
                else
                {
                    file.WriteLine("Closed method {0} in class {1} at line {2}", methodname, classname, line);
                    return;
                }
        }
    }
    public class Textbox_setup
    {
        string fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";

        public string Textbox_input(string textin)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@fileName, true))
            {
                file.Write(textin);
            }
            return fileName;
        }
        
    }
    public class PrimeCheck
    {
        public bool IsPrime(int num1)
        {

            for (int a = 2; a <= num1 / 2; a++)
            {

                if (num1 % a == 0)
                {
                    return false;
                }
            }

            return true;
            
        }
    }
    public class PrimeGenerateClass
    {
        PrimeCheck IsPrime = new PrimeCheck();
        Random Random = new Random();
        public int GeneratePrime()
        {
            int Number = 0;
            bool resault = false;
            while (resault == false)
            {
                Number = Random.Next(2, 74);
                resault = IsPrime.IsPrime(Number);
            }
            return Number;
        }
    }

}
