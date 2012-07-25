using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    
   
    class Program
    {
        private static ItemCollection it = new ItemCollection();
        static void Main(string[] args)
        {
            try
            {
                // get CSV file from command line
                string filepath="";
                if (args.Length > 0)
                {
                    filepath = args[0];
                    ReadFile(filepath);
                    foreach (string s in it.Sort())
                        Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine("Please enter file path");
                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
        static void ReadFile(string path)

        {
           
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                
                while((line=sr.ReadLine())!=null)
                {
                    it.Add(line);
                }
            }
            
        }
    }
}
