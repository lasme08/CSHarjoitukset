using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // 1 
            var rand = new Random();
            int num1 = rand.Next(1, 6);
            int num2 = rand.Next(1, 6);

            if (num1 == num2)
            {
                Console.WriteLine("samat");
                if (num1 == 1 && num2 == 1)
                {
                    Console.WriteLine("snake eyes");
                }
            }
            if (num1 != num2)
            {
                Console.WriteLine("eri");
            }

            // 2


            // 3
            Console.WriteLine("Rock paper or scissors");
            string rps = Console.ReadLine();

            int bot = rand.Next(1, 3);
            if (rps == "Rock" || rps == "rock")
            {
                if (bot == 1)
                {
                    Console.WriteLine("Rock, its a draw.");
                }
                else if (bot == 2)
                {
                    Console.WriteLine("Paper, you lose!");
                }
                else if (bot == 3)
                {
                    Console.WriteLine("Scissors, you win!");
                }
            }
            else if (rps == "Paper" || rps == "paper")
            {
                if (bot == 1)
                {
                    Console.WriteLine("Rock, you win!");
                }
                else if (bot == 2)
                {
                    Console.WriteLine("Paper, its a draw.");
                }
                else if (bot == 3)
                {
                    Console.WriteLine("Scissors, you lose!");
                }
            }
            else if (rps == "Scissors" || rps == "scissors")
            {
                if (bot == 1)
                {
                    Console.WriteLine("Rock, you lose!");
                }
                else if (bot == 2)
                {
                    Console.WriteLine("Paper, you win!");
                }
                else if (bot == 3)
                {
                    Console.WriteLine("Scissors, its a draw.");
                }
            }
            else
            {
                Console.WriteLine("Virheellinen syöte");
            }

            // 4
            
            int num = rand.Next(1, 10000);
            while (true) 
            {
                Console.WriteLine("Arvaa numero:");
                bool validInput = int.TryParse(Console.ReadLine(), out int guess);

                if (validInput) 
                {
                    if (guess == num)
                    {
                        Console.WriteLine("Oikein!");
                        break;
                    }
                    else if (guess < num)
                    {
                        Console.WriteLine("suurempi");
                    }
                    else if (guess > num) 
                    {
                        Console.WriteLine("pienempi");
                    }
                }
            }

            // 5
            Console.WriteLine();
            int ball1 = rand.Next(1, 39);
            int ball2 = rand.Next(1, 39);
            int ball3 = rand.Next(1, 39);
            int ball4 = rand.Next(1, 39);
            int ball5 = rand.Next(1, 39);
            int ball6 = rand.Next(1, 39);
            int ball7 = rand.Next(1, 39);
            List<int> list = new List<int>() {ball1, ball2, ball3, ball4, ball5, ball6, ball7 };
            foreach (int i in list)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            
            // 6
            while (true)
            {
                Console.WriteLine("Kuinka monta työtuntia?");
                bool validInput = decimal.TryParse(Console.ReadLine(), out decimal work_hours);
                Console.WriteLine("Mikä on tuntipalkka?");
                bool validInput1 = decimal.TryParse(Console.ReadLine(), out decimal pay);
                Console.WriteLine("Mikä on veroprosentti?");
                bool validInput2 = decimal.TryParse(Console.ReadLine(), out decimal tax_percent);
                if (validInput && validInput1 && validInput2) 
                {
                    if (work_hours <= 0 || pay <= 0 || tax_percent <= 0)
                    {
                        Console.WriteLine("Negatiivinen luku tai nolla");
                        break;
                    }
                    else
                    {
                        Tax(work_hours, pay, tax_percent);
                    }
                }
            }
            
            // 7
            Console.WriteLine("Kerro kuukausiostojen määrä:");
            bool validInput3 = (int.TryParse(Console.ReadLine(), out int ost));
            if (validInput3) 
            {
                Bonus(ost);
            }

            // 8
            Console.WriteLine("Anna suorakulmaiselle kolmiolle kateettien pituudet:");
            bool validInput4 = (double.TryParse(Console.ReadLine(), out double sivu_a));
            bool validInput5 = (double.TryParse(Console.ReadLine(), out double sivu_b));
            if (validInput4 && validInput5)
            {
                Kolmio(sivu_a, sivu_b);
            }


        }
        static void Tax(decimal a, decimal b, decimal c) 
        {
            
            decimal brutto = (a * b);
            decimal tax_percentage = (c / 100);
            decimal tax_amount = (brutto * tax_percentage);
            decimal netto = (brutto - tax_amount);
            Console.WriteLine("Bruttopalkka: "+(brutto));
            Console.WriteLine("Verojen määrä: "+(tax_amount));
            Console.WriteLine("Nettotulo: "+(netto));
        }

        static void Bonus(int a)
        {
            if (a > 500)
            {
                Console.WriteLine("Bonus on 3%");
            }
            else if (a > 340) 
            { 
                Console.WriteLine("Bonus on 2%");
            }
            else if (a > 170) 
            {
                Console.WriteLine("Bonus on 1,5%");
            }
            else if (a > 85) 
            {
                Console.WriteLine("Bonus on 1%");
            }
            else 
            {
                Console.WriteLine("Ei bonusta");
            }

        }

        static void Kolmio(double a, double b)
        {
            double hypotenuse_pow = (Math.Pow(a, 2) + Math.Pow(b, 2));
            double hypotenuse_sqrt = (Math.Sqrt(hypotenuse_pow));
            Console.WriteLine("Hypotenuusan pituus on "+(Math.Round(hypotenuse_sqrt)));
        }
    }
}
