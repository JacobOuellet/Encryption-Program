/*
 * Decrypt method
 * Author @ Jacob Ouellet
 * to decrypt encrypted text from enigma encryptor using rotor inputs
 * 11/21/17
 * viersion 0.0.1
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dictionary;
using Rotors;
using Utilities;

namespace Decrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "(IbOb~eSGTM~jSdmW~OReSs~hoZhi~cs.!K~(pn!l~-rx;dn~?!))v~6hcGA~y?(Ek~G)4J,~Lls(P~C1BHL~V6QY~-z l/";
            Decryption test = new Decryption();
            int r1 = 19, r2 = 59, r3 = 37, r4 = 7;
            response = test.DecryptText(response, r1,r2,r3,r4);
            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
    public class Decryption
    {
        Rotors.RotorMainClass BuildRotors = new Rotors.RotorMainClass();
        Utilities.PrimeGenerateClass GetPrime = new Utilities.PrimeGenerateClass();
        int x = 0, y = 0, z = 0, w = 0, count = 0;
        public void BuildRotorEncrypt(int r1, int r2, int r3, int r4)
        {
         //   r1 = 19; r2 = 59; r3 = 37; r4 = 7;
            BuildRotors.StartRotors(r1, r2, r3, r4);

        }
        public string DecryptText(string textin, int r1, int r2, int r3, int r4)
        { 
            BuildRotorEncrypt(r1, r2, r3, r4);
            string EncryptedText = null;
            char EncryptedChar;
            char[] Character = textin.ToCharArray();
            Character = Format(Character);
            for (int i = Character.Length; i > 0; i--)
            {
              
                int charIndex = GetInitialPosition(w, Character[count], BuildRotors.r4);
                EncryptedChar = Rotater(z, charIndex, BuildRotors.r3);
                EncryptedChar = Rotater(y, charIndex, BuildRotors.r2);
                EncryptedChar = Rotater(x, charIndex, BuildRotors.r1);
                x++;
                count++;
                charIndex -= x;
                if (charIndex <= -1)
                {
                    charIndex += 75;
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
                EncryptedChar = GetRotorIndex(charIndex, BuildRotors.Static);


                EncryptedText += EncryptedChar;
                // review what happens in rotator 2 and then do rotator 3 and four
               
            }
            return EncryptedText;
        }
        public int GetInitialPosition( int y, char letter, Rotor Stat)
        {
            int index;
            while (!(letter.Equals(Stat.letter)))
            {
                Stat = Stat.pointer;
            }
            if (Stat.Index - y <= -1)
            {
                index = (Stat.Index - y) + 75;
            }
            else
            {
                index = Stat.Index - y;
            }
            return index;
        }
        public char GetRotorIndex(int index, Rotor Rotor)
        {
            while (index != Rotor.Index)
            {
                Rotor = Rotor.pointer;
            }
            return Rotor.letter;
        }
        public char Rotater(int y, int charIndex, Rotor rotor)
        {
            char encryptedchar;
            if ( charIndex - y <= -1)
            {
                charIndex += 75;
                encryptedchar = GetRotorIndex(charIndex - y, rotor);
            }
            else
            {
                encryptedchar = GetRotorIndex(charIndex - y, rotor);
            }
            return encryptedchar;
        }
        public char[] Format(char[] characters)
        {
            characters = characters.Where(val => val != '~').ToArray();
            characters = characters.Where(val => val != '/').ToArray();
            int index = -1;
            for (int x = 0; x < characters.Length ; x++)
            {
                if (characters[x] != 0)
                {
                    index++;
                }
            }
            char[] formatedchars = new char[index];
            formatedchars = characters;
            return characters;
        }
    }
    
}
