using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enismmäinen numero?");
            bool validInput1 = double.TryParse(Console.ReadLine(), out double num1);


            Console.WriteLine("Toinen numero?");
            bool validInput2 = double.TryParse(Console.ReadLine(), out double num2);

            if (validInput1 && validInput2)
            {
                Console.WriteLine();
                Console.WriteLine("summa:" + (num1 + num2));
                Console.WriteLine("erotus:"+ (num1 - num2));
                Console.WriteLine("tulo:"+(num1 * num2));
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen ikä.");
            }
        }
    }
}
