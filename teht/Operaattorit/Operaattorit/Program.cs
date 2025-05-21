using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaattorit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // 1
            Console.WriteLine("Anna kaksi kokonaislukua");
            bool validInput = int.TryParse(Console.ReadLine(), out int luku1);
            bool validInput1 = int.TryParse(Console.ReadLine(), out int luku2);
            if (validInput && validInput1)
            {
                Console.WriteLine("summa: " + (luku1 + luku2));
                Console.WriteLine("erotus: " + (luku1 - luku2));
                Console.WriteLine("tulo: " + (luku1 * luku2));
                if (luku2 != 0)
                {
                    Console.WriteLine("osamäärä: " + (luku1 / luku2));
                    Console.WriteLine("jakojäännos: " + (luku1 % luku2));
                }
                else
                {
                    Console.WriteLine("On mahdotonta jakaa nollalla");
                }

            }
            else
            {
                Console.WriteLine("Virheellinen syöte.");
            }

            // 2
            Console.WriteLine("Anna kaksi kokonaislukua");
            bool validInput2 = int.TryParse(Console.ReadLine(), out int luku3);
            bool validInput3 = int.TryParse(Console.ReadLine(), out int luku4);
            if (validInput2 && validInput3)
            {
                if (luku3 == luku4) { Console.WriteLine("luvut ovat yhtäsuuria"); }
                else if (luku3 != luku4) { Console.WriteLine("luvut ovat erisuuria"); }
                if (luku3 < luku4) { Console.WriteLine("ensimmäinen luku on pienempi"); }
                else if (luku3 > luku4) { Console.WriteLine("ensimmäinen luku on suurempi"); }

            }
            else
            {
                Console.WriteLine("Virheellinen syöte.");
            }

            // 3
            Console.WriteLine("Anna kaksi totuusarvoa");
            bool validInput4 = bool.TryParse(Console.ReadLine(), out bool totuus1);
            bool validInput5 = bool.TryParse(Console.ReadLine(), out bool totuus2);
            if (validInput4 && validInput5)
            {
                if (totuus1 && totuus2) { Console.WriteLine("totuudet ovat samoja"); }
                if (totuus1 || totuus2) { Console.WriteLine("ainakin yksi totuus sanoo true"); }
                if (!totuus1 && totuus2) { Console.WriteLine("totuus 1 on eri kuin totuus 2"); }
            }
            else
            {
                Console.WriteLine("Virheellinen syöte.");
            }

            // 4
            Console.WriteLine("Anna arvo");
            bool validInput6 = double.TryParse(Console.ReadLine(), out double arvo1);
            if (validInput6)
            {
                arvo1 += 5;
                Console.WriteLine("Arvo + 5 = " + arvo1);
                arvo1 -= 5;

                arvo1 *= 2;
                Console.WriteLine("Arvo * 2 = " + arvo1);
                arvo1 /= 2;

                arvo1 /= 3;
                Console.WriteLine("Arvo / 3 = " + arvo1);
                arvo1 *= 3;

            }
            else { Console.WriteLine("Virheellinen syöte."); }

            // 5
            Console.WriteLine("Anna kokonaisluku");
            bool validInput7 = int.TryParse(Console.ReadLine(), out int luku5);
            if (validInput7)
            {
                if (luku5 % 2 == 0)
                {
                    Console.WriteLine("luku on parillinen");
                }
                if (luku5 % 3 == 0)
                {
                    Console.WriteLine("luku on jaollinen kolmella");
                }
            }
            else { Console.WriteLine("Virheellinen syöte."); }

            // 6
            Console.WriteLine("Anna kaksi kokonaislukua");
            bool validInput8 = int.TryParse(Console.ReadLine(), out int luku6);
            bool validInput9 = int.TryParse(Console.ReadLine(), out int luku7);
            if (validInput8 && validInput9)
            {
                Console.WriteLine("AND = " + (luku6 & luku7));
                Console.WriteLine("OR = " + (luku6 | luku7));
                Console.WriteLine("XOR = " + (luku6 ^ luku7));
                Console.WriteLine("Vasen siirto = " + (luku6 << luku7));
                Console.WriteLine("Oikea siirto = " + (luku6 >> luku7));
            }
            else
            {
                Console.WriteLine("Virheellinen syöte.");
            }
            // 7
            Console.WriteLine("Anna Kokonaisluku");
            bool validInput10 = int.TryParse(Console.ReadLine(), out int luku8);
            if (validInput10)
            {
                if (luku8 > 0)
                {
                    Console.WriteLine("Luku on positiivinen");
                }
                if (luku8 < 0)
                {
                    Console.WriteLine("Luku on negatiivinen");
                }
                if (luku8 == 0)
                {
                    Console.WriteLine("Luku on 0");
                }
            }
            else
            {
                Console.WriteLine("Virheellinen syöte.");
            }

            // 8
            Console.WriteLine("Anna kolme kokonaislukua");
            bool validInput11 = int.TryParse(Console.ReadLine(), out int luku9);
            bool validInput12 = int.TryParse(Console.ReadLine(), out int luku10);
            bool validInput13 = int.TryParse(Console.ReadLine(), out int luku11);
            if (validInput11 && validInput12 && validInput13)
            {
                if (luku9 == luku10 && luku10 == luku11)
                {
                    Console.WriteLine("luvut ovat samoja");
                }
                else if (luku9 <= luku10 && luku10 <= luku11)
                {
                    Console.WriteLine("luvut ovat kasvavassa järjestyksessä");
                }
                else if (luku9 >= luku10 && luku10 >= luku11)
                {
                    Console.WriteLine("luvut ovat laskemassa järjestyksessä");
                }
                else
                {
                    Console.WriteLine("luvut ei ole järjestyksessä");

                }

            }
            else { Console.WriteLine("Virheellinen syöte"); }
            

            //9
            int vasen_x = 0;
            int oikea_x = 10;
            int yla_y = 0;
            int ala_y = 10;
            Console.WriteLine("Kerro x ja y kordinaatti kokonaislukuna");
            bool validInput14 = int.TryParse(Console.ReadLine(), out int x);
            bool validInput15 = int.TryParse(Console.ReadLine(),out int y);
            if (validInput14 && validInput15)
            {
                if (x > vasen_x && x < oikea_x && y > yla_y && y < ala_y)
                {
                    Console.WriteLine("Piste on suorakulmion sisällä");
                }
                else
                {
                    Console.WriteLine("Piste ei ole suorakulmion sisällä");
                }
            }
            else { Console.WriteLine("Virheellinen syöte"); }

        }
    }
}
