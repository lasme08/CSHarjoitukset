using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koulutyo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             int a = 3;
             int b = 6;

             if (a == b) // Jos A sama kuin B
             {
                 Console.WriteLine("A on yhtä suuri kuin B");
             }

             if (a < b)
             {
                 Console.WriteLine("A on pienempi kuin B");
             }

             if (a > b)
             {
                 Console.WriteLine("A on suurempi kuin B");
             }

             if (a <= b)
             {
                 Console.WriteLine("A on pienempi tai yhtäsuuri kuin b");
             }

             if (a >= b)
                 Console.WriteLine("A on suurempi tai yhtäsuuri kuin b");

             if (a != b)
             {
                 Console.WriteLine("A on erisuuri");
             }

             int c = 4;
             int d = 4;

             if (c == d)
             {
                 Console.WriteLine("C on yhtä kuin D");
             }
             else
             {
                 Console.WriteLine("Edellinen ehto ei ollut totta");    
             }
             int e = 5;
             int f = 6;
             int g = 7;

             if (e < f && f < g)
             {
                 Console.WriteLine("Oli totta");
             }
             else
             {
                 Console.WriteLine("Ei ollut totta");
             }

             if (e < f || f < g)
             {
                 Console.WriteLine("Tai Oli totta");
             }
            */

            // Ehtolauseet
            // Tehtävä 1:
            Console.WriteLine("What's the code?");
            string code = "1234";
            string koodi = Console.ReadLine();
            if (koodi == code)
            {
                Console.WriteLine("CORRECT!");
            }
            // Tehtävä 2:
            Console.WriteLine("How old are you?");   
            string v = Console.ReadLine();
            int age = Int32.Parse(v);
            if (age > 18)
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("You are underage, please leave");
            }
            // Tehtävä 3:
            Console.WriteLine("What did you get on your latest test?");

        }
    }
}
