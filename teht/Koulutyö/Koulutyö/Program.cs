using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koulutyö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rivin loppuun tulee puoli piste (;)
            // Tehtävä 1.
            string pro = "AHAHAHAHAAAAHAHAHAHHAHHAHHAHAHAHHAHAHAHAHA";
            Console.WriteLine(pro);
            Console.WriteLine();
            // Tehtävä 2.
            int num1 = 7;
            int num2 = 15;
            Console.WriteLine(num1 + num2);
            Console.WriteLine();
            // Tehtävä 3.
            int numero1 = 32;
            int numero2 = 16;
            int numero3 = 8;
            int numerot = (numero1 + numero2 + numero3);
            Console.WriteLine(numerot / 3);
            Console.WriteLine();
            // Tehtävä 4.
            int kokonaisluku = 16;
            Console.WriteLine(kokonaisluku);
            kokonaisluku = 32;
            Console.WriteLine(kokonaisluku) ;
            Console.WriteLine();
            // Muuttujan Arvon Muuttaminen
            // Tehtävä 1.
            int number1 = 4;
            int number2 = 8;

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            number1 += number2;
            Console.WriteLine(number1);
            Console.WriteLine();
            // Tehtävä 2.
            int kokluku = 12;
            Console.WriteLine(kokluku);
            kokluku *= 2;
            Console.WriteLine(kokluku);
            Console.WriteLine();
            // Tehtävä 3.
            float liukunum1 = 13;
            float liukunum2 = 4;
            Console.WriteLine(liukunum1);
            Console.WriteLine(liukunum2);
            liukunum1 *= liukunum2;
            Console.WriteLine(liukunum1);
            Console.WriteLine();
            // Tehtävä 4.
            int koknum1 = 5;
            int koknum2 = 10;
            koknum1 += 15;
            koknum2 += 15;
            Console.WriteLine(koknum1);
            Console.WriteLine(koknum2);
            Console.WriteLine();
            // Input
            // Tehtävä 1.
            Console.WriteLine("Mikä on nimesi?");
            string name = Console.ReadLine();
            Console.WriteLine("Terve " + name);
            Console.WriteLine();


        }
    }
}
