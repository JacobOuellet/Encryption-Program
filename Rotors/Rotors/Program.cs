/*
 * Rotors for enigma
 * Jacob Ouellet
 * 10/7/17
 * 0.0.1
 * This program sets up the rotor and the rotor objects that are used to set up the ofset. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dictionary;

namespace Rotors
{
    class Program
    {        
        static void Main(string[] args)
        {
        }
    }
    public class RotorMainClass
    {
        RotorOffset Statrot = new RotorOffset();
       public Rotor r1 = null, r2 = null, r3 = null, r4 = null , Static = null;
        public void StartRotors(int Rotor1Offset, int Rotor2Offset, int Rotor3Offset, int Rotor4Offset)
        {
            RotorMainClass RotMain = new RotorMainClass();

            string[] Letters = new string[75];
            Dictionary.Dictionaryclass Dict = new Dictionaryclass();
            Dict.let = null;
            Dict.let.CopyTo(Letters, 0);

            for (int count = 0; count < 75; count++) // loop to copy dictionary to static rotor
            {
                char character;
                character = Convert.ToChar(Letters[count]);
                Static = StatRot.BuildSR(Static, character);
            }

            r1 = RotMain.RotorMain(Static, Rotor1Offset, r1);
            r2 = RotMain.RotorMain(r1, Rotor2Offset, r2);
            r3 = RotMain.RotorMain(r2, Rotor3Offset, r3);
            r4 = RotMain.RotorMain(r3, Rotor4Offset, r4);

        }
        public static RotorOffset StatRot = new RotorOffset();
        public Rotor RotorMain(Rotor rstat, int r1offset, Rotor r1)
        {
            StatRot.nullcount();
            Queue<char> offset = new Queue<char>();
            for (int count = 0; count <= 74; count++)
            {
                if (rstat.Index >= r1offset && rstat.Index < 75) // starts building char once the offset reaches 19
                {
                    r1 = StatRot.BuildR1(r1, rstat.letter);
                    if (count != 74)
                    {
                        rstat = rstat.pointer;
                    }
                }
                else if (rstat.Index <= (r1offset - 1)) // chars before 19 are saved in an array to be added after 19-74 is added to rotor 1
                {
                    offset.Enqueue(rstat.letter);
                    rstat = rstat.pointer;
                }
                if (count == 74) // if once 19-74 is in the rotor1 it adds 0-18 to the end of the rotor to build the offset
                {
                    while (offset.Count > 0)
                    {
                        r1 = StatRot.BuildRotor(r1, offset.Dequeue());
                    }

                }
            }
            return r1;
        }
    }
    public class RotorOffset
    {
        public Rotor StaticR;
        int count;

        public void nullcount() // doesnt actually null count juyst sets to zero so that each index in each rotor starts at 0
        {
            count = 0;
        }

        //----------------------------------------StaticRotor
        public Rotor BuildSR(Rotor Static, char character)
        {
            Static = BuildStaticRotor(Static, character);
            return Static;
        }
        public Rotor BuildStaticRotor(Rotor StaticR, char character) //builds the base static rotor copy of dictionar
        {
            if (StaticR == null)
            {
                StaticR = new Rotor(character, count);
                count++;
                return StaticR;
            }
            else
            {
                StaticR.pointer = BuildStaticRotor(StaticR.pointer, character);
            }
            return StaticR;

        }

        // -----------------------------------------Rotor1
        public Rotor BuildR1(Rotor r1, char character)
        {
            r1 = BuildRotor(r1, character);
            return r1;
        }
        public Rotor BuildRotor(Rotor rot, char character) // builds rotor 1
        {
            if (rot == null)
            {
                rot = new Rotor(character, count);
                count++;
                return rot;
            }
            else
            {
                rot.pointer = BuildRotor(rot.pointer, character); // recurtion is utilized to minimize code
            }
            return rot;
        }
    
    }
    public class Rotor // rotor object contains int for index rotor pointer and char for the letter
    {
        public char letter;
        public Rotor pointer;
        public int Index;
        public Rotor(char value, int count)
        {
            letter = value;
            pointer = null;
            Index = count;
        }
    }
}
