using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Luku_ja_Kirjoitus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            
            string filepath = "test.txt";
            string filepathcopy = "test2.txt";

           using (StreamWriter sw = File.CreateText(filepath)) 
            {
                sw.WriteLine("AAA");
                sw.WriteLine("haha");
                File.Copy(filepath, filepathcopy, true);
            }

           if (File.Exists(filepathcopy)) 
            {
                File.Delete(filepathcopy);
            }
            

            // 2
            
            string filepath1 = "teht2.txt";
            string t2l1 = "Hello";
            string t2l2 = "World!";
            File.WriteAllText(filepath1, t2l1);
            File.AppendAllText(filepath1,"\n"+ t2l2);

            if (File.Exists(filepath1))
            {
                string filepathcopy2 = "Kopio1.txt";
                string[] readtext = File.ReadAllLines(filepath1);
                File.WriteAllText(filepathcopy2, readtext[0]);
                File.AppendAllText(filepathcopy2, readtext[1]);

            }
            else 
            {
                Console.WriteLine("Tiedosto ei ole olemassa.");
            }
            
            // 3
            string filepath2 = "teht3.txt";
            string t3l1 = "AAA";
            string t3l2 = "BBB";
            string t3l3 = "CCC";
            File.WriteAllText (filepath2, t3l1);
            File.AppendAllText (filepath2,"\n"+t3l2);
            File.AppendAllText ( filepath2,"\n"+t3l3);
            
            string filepath3 = "teht3_1.txt";

            using (StreamReader sr = new StreamReader(filepath2)) 
            {
                using (StreamWriter sw = new StreamWriter(filepath3))
                {
                    string line;
                    int number = 1;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(number+". "+line);
                        number++;
                    }

                }
                
            }

            // 4
            string filepath4 = "teht4";


        }
    }
}
