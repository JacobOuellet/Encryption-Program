using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2;


namespace Decrypt_Output
{ 
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public partial class OutputDecrypt 
    {
       
        WindowsFormsApp2.Text_Output output = new WindowsFormsApp2.Text_Output();
        public void Output(string response, string text, string filename)
        {
            if (response.Equals("file"))
            {
                using (StreamWriter write = new StreamWriter(@filename, true))
                {
                    write.WriteLine(text);
                }
            }    
            else if (response.Equals("textbox"))
            {
                output.Output(text);
                output.Show();
            }

        }
    }
}
