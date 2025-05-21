using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        // 1
        static void Hello()
        {
            Console.WriteLine("Hello world!");
        }
        static void Main(string[] args)
        {

            /*
            Hello();
            Greet();
            Square();
            Sum();
            IsEven();
            Calculatesum();
            Fibonacci(); 
            */
            Console.WriteLine("Minkä fibonacci sarjan luvun haluat tietää?");
            bool validInput4 = int.TryParse(Console.ReadLine(), out int luku4);
            if (validInput4)
            {
                Fibonacci(luku4);
            }

            Console.WriteLine("Anna kokonaisluku");
            bool validInput = int.TryParse(Console.ReadLine(), out int luku3);
            if (validInput)
            {
                PrintTriangle(luku3);
            }


            Console.WriteLine("Ensimmäinen luku: ");
            bool validInput1 = int.TryParse(Console.ReadLine(), out int luku1);
            Console.WriteLine("Toinen luku: ");
            bool validInput2 = int.TryParse(Console.ReadLine(), out int luku2);
            if (validInput2 && validInput1)
            {
                Swap(luku1, luku2);
            }
        }

        // 2
        static void Greet()
        {
            Console.WriteLine("Mikä on nimesi?");
            string name = Console.ReadLine();
            Console.WriteLine("Moi " + name + "!");
        }

        // 3
        static void Square()
        {
            int sqr_num = 12;
            Console.WriteLine(Math.Pow(sqr_num, 2));
        }

        // 4
        static void Sum()
        {

            Console.WriteLine("Anna kaksi kokonaislukua");
            bool validInput = int.TryParse(Console.ReadLine(), out int sum_num1);
            bool validInput1 = int.TryParse(Console.ReadLine(), out int sum_num2);
            if (validInput && validInput1)
            {
                Console.WriteLine("Summa: " + (sum_num1 + sum_num2));
            }
        }

        // 5
        static void IsEven()
        {
            Console.WriteLine("Anna kokonaisluku");
            bool validInput = int.TryParse(Console.ReadLine(), out int luku1);
            if (validInput)
            {
                if (luku1 % 2 == 0)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else
            {
                Console.WriteLine("Virheellinen syöte");
            }
        }

        // 6
        static void Calculatesum()
        {
            Console.WriteLine("Anna kolme kokonaislukua");
            bool validInput = int.TryParse(Console.ReadLine(), out int luku1);
            bool validInput1 = int.TryParse(Console.ReadLine(), out int luku2);
            bool validInput2 = int.TryParse(Console.ReadLine(), out int luku3);

            if (validInput && validInput1 && validInput2)
            {
                Console.WriteLine((luku1 + luku2 + luku3));
            }
            else { Console.WriteLine("Virheellinen syöte"); }
        }

        // 7
        static void Fibonacci(int n)
        {
            int count = n;
            int fib1 = 0;
            int fib2 = 1;
            for (int i = 0; i <= count; i++)
            {
                if (i == count)
                {
                    Console.WriteLine(fib1);
                }
                int nextfib = fib1 + fib2;
                fib1 = fib2;
                fib2 = nextfib;
            }
        }
        // 8
        static void PrintTriangle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string result = new string('*', i);
                Console.WriteLine("*" + result);
            }
        }

        // 9
        static void Swap(int a, int b)
        {
            Console.WriteLine();
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}    
