using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using Rotors;

namespace Encrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "Hi my ~name is jacob ouellet. I live in Raymond NH, and I am a CIS major at MCC.";
           
            Encrypt test = new Encrypt();
            EncryptedPackage x = new EncryptedPackage();
            x = test.EncyptText(response);
            Console.WriteLine(x.key);
            Console.WriteLine(x.text);
            Console.ReadLine();
        }
    }
    public class Encrypt
    {
        Utilities.PrimeGenerateClass GetPrime = new Utilities.PrimeGenerateClass();
        Rotors.RotorMainClass BuildRotors = new Rotors.RotorMainClass();
        int x = 1, y = 0, z = 0, w = 0, count = 0;
        public string BuildRotorEncrypt()
        {
            int r1, r2, r3, r4;
            string key;
            r1 = GetPrime.GeneratePrime();
            r2 = GetPrime.GeneratePrime();
            r3 = GetPrime.GeneratePrime();
            r4 = GetPrime.GeneratePrime();
            //r1 = 19; r2 = 59; r3 = 37; r4 = 7;
            key = "Rotor settings: " + r1.ToString() + " " + r2.ToString() + " " + r3.ToString() + " " + r4.ToString();
            BuildRotors.StartRotors(r1, r2, r3, r4);
            return key;
        }
        public EncryptedPackage EncyptText(string textin)
        {
            string key = BuildRotorEncrypt();
            string EncryptedText = null;
            char EncryptedChar;
             char[] Character = textin.ToCharArray();
            for (int i = Character.Length; i > 0; i--)
            {
                
                int charIndex = GetInitialPosition(Character[count], BuildRotors.Static);
                count++;
                charIndex += x;
                    if (charIndex >= 75)
                    {
                        charIndex -= 75;
                       
                    }
                if (x == 75)
                {
                    x = 0;
                    y += 1;
                    if (y == 75)
                    {
                        y = 0;
                        z += 1;
                        if (z == 75)
                        {
                            z = 0;
                            w += 1;
                            if (w == 75)
                            {
                                w = 0;
                            }
                        }
                    }
                }
                EncryptedChar = GetRotorIndex(charIndex, BuildRotors.r1);
                EncryptedChar = Rotater(y, EncryptedChar, charIndex, BuildRotors.r2);
                EncryptedChar = Rotater(z, EncryptedChar, charIndex, BuildRotors.r3);
                EncryptedChar = Rotater(w, EncryptedChar, charIndex, BuildRotors.r4);
                EncryptedText += EncryptedChar;
                // review what happens in rotator 2 and then do rotator 3 and four
                x++;
            }
            EncryptedPackage package = new EncryptedPackage();
            package.Set(EncryptedText, key);
            return package;
        }
        public int GetInitialPosition(char letter, Rotor Stat)
        {
            try
            {
                while (!(letter.Equals(Stat.letter)))
                {
                    Stat = Stat.pointer;
                }
            }
            catch
            {
                Stat = BuildRotors.Static;
                while (!(' '.Equals(Stat.letter)))
                {
                    Stat = Stat.pointer;
                }
            }
            return Stat.Index;
        }
        public char GetRotorIndex(int index, Rotor Rotor)
        {
           while (index != Rotor.Index)
           {
              Rotor = Rotor.pointer;
           }
            return Rotor.letter;
        }
        public char Rotater(int y, char encryptedchar, int charIndex, Rotor rotor)
        {
            if (y + charIndex >= 75)
            {
                charIndex -= 75;
                encryptedchar = GetRotorIndex(charIndex + y, rotor);
            }
            else
            {
                encryptedchar = GetRotorIndex(charIndex + y, rotor);
            }
            return encryptedchar;
        }
    }
    public class EncryptedPackage
    {
        public string text;
        public string key;
        public void Set(string text, string key)
        {
            this.key = key;
            this.text = text;
        }
    }   
}
