using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Function_tehtäväpaketti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Call();
            Hurt();
            Multiply(5);
            PlusOne(123);
            string askname = Console.ReadLine();
            Greet2(askname);

            bool validInput = int.TryParse(Console.ReadLine(), out int num1);
            if (validInput) 
            {
                Hello(num1);
            }

            Summa(23, 55);
            Positive(-5);
            
        }
        // Funktiot

        // 1
        static void Greet() 
        {
            Console.WriteLine("Hello World!");
        }

        // 2
        static void Call() 
        {
            Greet();
        }

        // 3
        static void Hurt() 
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("AUTS!");
            }
        }

        // Parametri ja Argumentit

        // 1
        static void Multiply(int n)
        {
            Console.WriteLine(n * 2);
        }

        // 2
        static void PlusOne(int num)
        {
            Console.WriteLine(num+1);
        }

        // 3
        static void Greet2(string name) 
        {
            Console.WriteLine("Hello "+name+"!");
        }

        // 4
        static void Hello(int a) 
        {
        for (int i = 0 ; i < a; i++) 
            {
                Console.WriteLine("Hello world!");
            }
        }

        // Palautus

        // 1
        static int Summa(int a, int b)
        {
            int c = (a + b);
            return c;
        }
        
        // 2
        static int Positive(int a) 
        {
            int abs = Math.Abs(a);
            return abs;
        }

        // 3
        static string Last(string name) 
        {
        
        }
    }
}
