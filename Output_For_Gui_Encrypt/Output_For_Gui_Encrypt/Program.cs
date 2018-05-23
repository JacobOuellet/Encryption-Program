/* outbound for enigma
 * Author: Jacob Ouellet
 * 10/25/17
 * version 0.0.1
 * This program sets up a html file for the encrypted text to be output in or a text box depending on the users selction
 * it outputs the text in 5 character chunks
*/
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using Screens;
using WindowsFormsApp2;


namespace Output
{
    class Program
    {
         
        static void Main(string[] args)
        {
            Utilities.Logfile log = new Logfile();
           // log.Log("Main", "Program", 21, 1);
            string teststring = System.IO.File.ReadAllText(@"C:\Users\jacob\OneDrive\Documents\TestFolder\Gettysburg Address.txt"); ; //test input
            Output test = new Output();
        //    test.GetText(teststring);  // calls gettext method in output class
            Console.ReadLine();
        //    log.Log("Main", "Program", 21, 0);
        }
    }
    public class Output
    {
        private string text5, spacechar, linebreakchar, response;                 // text5 holds 5 chars to make a string, spacechar is the space character instead of blanks, linebreak char shows end of line
        private int chunksize, count, chunksizerem, wordsperlinecount, wordsperline;
        // chunksize = how big the char length for text5 compounds by 5 after each print, chunksizerem becomes the remainder for the letters left i.e. if there are only three numbers remaining at end of transmistion
        // its used 
        WindowsFormsApp2.Text_Output Out = new WindowsFormsApp2.Text_Output();
        public Output()
        {
            chunksize = 5;                                   // how many char per word pritned, compounds by itself after each pass until greater than string length.
            count = 0;
            chunksizerem = 5;                                // constant that only changes when its time for remainder at the end
            wordsperline = 1;                 
            wordsperlinecount = 0;                           // just a count starts at 1 becuase 5 words per line starts at 0
            spacechar = "~";                               // space char
            linebreakchar = "/"; 
        }
        public void Textorfile(string text, string key, string textboxOrFile, string filename)
        {
            Screens.ErrorSreens error = new ErrorSreens();
            Screens.Screens screen = new Screens.Screens();
            Start:                                      // line end char
            if (textboxOrFile.Equals("textbox"))
            {
                response = "textbox";
                Out.Output(key);
                Out.Show();
                GetText(text, key, null);
            }
            else if (textboxOrFile.Equals("file"))
            {
                response = "file";
                int x = filename.IndexOf(".");
                string keyfilename = filename.Insert(x, "key");
                    using (StreamWriter write = new StreamWriter(@keyfilename))
                    {
                        write.WriteLine(key);
                        write.Close();
                    }
                   
                    GetText(text, key, filename);
               
               
            }
            else
            {
                error.InputTextError();
                response = null;
                goto Start;
            }
        }
        public void GetText(string InitialText, string key, string filename)
        {
            //Utilities.Logfile log = new Logfile();
            
            try
           { 
          // log.Log("GetText", "Output", 47, 1);

                if (chunksize > InitialText.Length)            // if chunksize is greater than length of string
            {
                    chunksize = InitialText.Length;                // and makes chunksize equal to that plus chunksize minus amount
                spacechar = linebreakchar;                                        // need linebreak char if its remainder
                GetText(InitialText, key, filename);                                              // calls the method again recurs
                return;
            }
            if (count == chunksize)                     // if count == chunksize it prints out text5 by going to text out method
            {
                wordsperlinecount++;
                TextOut(text5, spacechar, wordsperline, filename); // passes char string text 5, the space character, amount of words per line and the count for it
                text5 = null;                                             // once its done it nulls tex5
                spacechar = "~";                                          // space char is defaulted incase linebreak was set in above
                                                      // words per line count is increased
            }
            if (count == InitialText.Length)                              // if count == text legth then it ends
            {
                return;
            }
            text5 += InitialText[count].ToString();                     // add char to text5
            count++;                                           
            GetText(InitialText, key, filename);                                      // recurstion call to move down to the next char 
          //  log.Log("GetText", "Output", 47, 0);
            }
            catch
            {
               // log.Log("GetText", "Error_________________________________", 47, 1);
                count++;                  
                GetText(InitialText, key, filename);
            }

        }
        private void TextOut(string text5, string endline_linebreak, int wordsperlines, string filename)
        {
            //Utilities.Logfile log = new Logfile();
            if (response.Equals("file"))
            {
               try
               {
                    //  log.Log("Textout", "Output", 76, 1);
                    using (System.IO.StreamWriter write = new System.IO.StreamWriter(@filename, true)) // drive location for the file storage
                    {
                        if (wordsperlines == wordsperlinecount)       // if they equal then it create snew line and uses new line char that would have been set to spacechar in the gettext meth
                        {
                            endline_linebreak = linebreakchar;
                            write.WriteLine(text5 + endline_linebreak);
                            wordsperlinecount = 0;
                            // set back to zero because its a new line now
                        }
                        else
                        {
                            write.Write(text5 + endline_linebreak);   //  else just adds the string to the line

                        }
                    }
                    chunksize += chunksizerem;           // chunksize it increased by string length size     
                                                         // log.Log("Textout", "Output", 76, 0);
                    return;
               }
              catch
               {
                    //log.Log("TextOut", "Error_________________________________", 76, 1);
                    return;
               }
            }
            else if (response.Equals("textbox"))
            {
                try
                {
                    //  log.Log("Textout", "Output", 76, 1);

                    if (wordsperlines == wordsperlinecount)       // if they equal then it create snew line and uses new line char that would have been set to spacechar in the gettext meth
                    {
                        endline_linebreak = linebreakchar;
                        Out.Output(text5 + endline_linebreak);
                        wordsperlinecount = 0;
                        // set back to zero because its a new line now
                    }
                    else
                    {
                        Out.Output(text5 + endline_linebreak);   //  else just adds the string to the line

                    }
                    chunksize += chunksizerem;           // chunksize it increased by string length size     
                                                         // log.Log("Textout", "Output", 76, 0);
                    return;
                }
                catch
                {
                    //log.Log("TextOut", "Error_________________________________", 76, 1);
                    return;
                }
            }
        }
    } // currrent log append ket to new file.

}
/*
 * Objectives:
 * 1 .	Set up your output file. This is the file that will be encrypted. 
2 .	Encrypt it so that there are five characters to a line, no more no less. You may toss out the character itself if you wish.
3 .	The file will be a .html file.
4 .	You should be able to use a special character for the CR/LF.
5 .	Blanks are not allowed, again you should have enough characters to make this work.
6 .	Make things work first then encrypt. That way if you have any problems you will be able to rectify them.
7 .	Have this up and running in a class of its own by next week. 
 */
