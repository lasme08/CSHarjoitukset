using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Whileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // 1
            int luku1 = 1;
            while (luku1 <= 10)
            {
                Console.WriteLine(luku1);
                luku1 += 1;
            }
            Console.WriteLine();

            // 2
            int luku2 = 1;
            while (luku2 <= 100)
            {
                if ((luku2 % 2) == 0)
                {
                    Console.WriteLine("Parillinen" + (luku2));
                }
                else if (luku2 % 3 == 0)
                {
                    Console.WriteLine("Pariton" + (luku2));
                }
                luku2 += 1;
            }

            // 3
            bool validInput = int.TryParse(Console.ReadLine(), out int luku3);
            bool validInput2 = int.TryParse(Console.ReadLine(), out int luku4);
            if (validInput && validInput2)
            {
                if ((luku3 >= 0) && (luku4 >= 0))
                {
                    while (luku3 >= 0 && luku4 >= 0)
                    {
                        Console.WriteLine("Summa on " + (luku3 + luku4));
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Virheellinen syöte");
            }
            
            // 4
            Random rand = new Random();
            int vastaus = rand.Next(1, 100);
            Console.WriteLine("Arvaa numero:");
            while (true)
            {
                bool validInput3 = int.TryParse(Console.ReadLine(), out int luku5);
                if (validInput3)
                {
                    if (luku5 == vastaus)
                    {
                        Console.WriteLine("Oikein!");
                        break;
                    }
                    else if ((luku5 > vastaus))
                    {
                        Console.WriteLine("Liian suuri");
                    }
                    else if ((luku5 < vastaus))
                    {
                        Console.WriteLine("Liian pieni");
                    }
                    if (luku5 == vastaus - 1 || luku5 == vastaus + 1 || luku5 == vastaus - 2 || luku5 == vastaus + 2)
                    {
                        Console.WriteLine("Olet lähellä!");
                    }
                }
                else { Console.WriteLine("Virheellinen syöte."); }
            }
            
            // 5
            
            int count = 10;
            int fib1 = 0;
            int fib2 = 1;

            while (count > 0) 
            {
                Console.WriteLine(fib1);
                int nextfib = fib1 + fib2;
                fib1 = fib2;
                fib2 = nextfib;
                
            }

            // 6
            int count2 = 1;
            Console.WriteLine("Anna luku");
            bool validInput4 = int.TryParse(Console.ReadLine(), out int luku6);
            if (validInput4)
            {
                while (count2 <= 10)
                {
                    Console.WriteLine("Luku kertaa " + (count2) + " on " + (luku6 * count2));
                    count2++;
                }
            }
            else
            {
                Console.WriteLine("Virheellinen syöte");
            }

            // 7
            Console.WriteLine("Anna luku");
            double tavoite = 5000;
            double korotus = 0.025;
            bool validInput5 = double.TryParse(Console.ReadLine(), out double luku7);
            if (validInput5)
            {
                while (luku7 < tavoite)
                {
                    Console.WriteLine(luku7);
                    luku7 = (luku7 + (luku7 * korotus));
                }
            }
        }
    }
}
