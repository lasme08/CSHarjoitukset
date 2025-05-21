using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            string ss = "ABABAB1";
            bool oikein = false;
            while (oikein == false) 
            {
                Console.WriteLine("Mikä on salasana?");
                string ss2 = Console.ReadLine();
                if (ss2 == ss)
                {
                    Console.WriteLine("Oikein!");
                    oikein = true;
                }
                else
                {
                    Console.WriteLine("Väärin");
                }
                Console.WriteLine();
            }

            // 2
            bool negatiivinen = false;

             while (negatiivinen == false) 
            {
                Console.WriteLine("Anna kaksi lukua. Luvut ei saa olla negatiivisia");
                bool validInput = int.TryParse(Console.ReadLine(), out int luku);
                bool validInput2 = int.TryParse(Console.ReadLine(),out int luku2);
                if (validInput && validInput2)
                {
                    if (luku >= 0 && luku2 >= 0)
                    {
                        var arr = new int[] { luku, luku2 };
                        double avg = Queryable.Average(arr.AsQueryable());
                        Console.WriteLine("Keskiarvo on " + avg);
                    }
                    else
                    {
                        Console.WriteLine("Älä anna negatiivisia lukuja.");
                        negatiivinen = true;
                    }
                }
                else 
                {
                    Console.WriteLine("Virheellinen syöte.");
                }
            }

        }
    }
}
