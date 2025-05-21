using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joslauseet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // 1
            Console.WriteLine("Anna luku");
            bool validInput = int.TryParse(Console.ReadLine(), out int luku);
            if (validInput)
            {
                if (luku % 2 == 0)
                {
                    Console.WriteLine("luku on parillinen");
                }
                else
                {
                    Console.WriteLine("luku on pariton");
                }
            }
            else { Console.WriteLine("Virheellinen syöte"); }

            // 2
            Console.WriteLine("Anna luku");
            bool validInput2 = int.TryParse(Console.ReadLine(), out int luku2);
            if (validInput2) 
            {
                if (luku2 > 0)
                {
                    Console.WriteLine("luku on positiivinen");
                }
                else if (luku2 < 0)
                {
                    Console.WriteLine("luku on negatiivinen");
                }
                else if (luku2 == 0)
                {
                    Console.WriteLine("luku on nolla");
                }
            }
            else 
            {
                Console.WriteLine("Virheellinen syöte");
            }

            // 3
            Console.WriteLine("Anna kolme lukua");
            bool validInput3 = int.TryParse(Console.ReadLine(),out int luku3);
            bool validInput4 = int.TryParse(Console.ReadLine(),out int luku4);
            bool validInput5 = int.TryParse(Console.ReadLine(), out int luku5);
            if (validInput3 && validInput4 && validInput5) 
            {
                if (luku3 >= luku4 && luku3 > luku5)
                {
                    Console.WriteLine("ensimmäinen luku on isoin");
                }
                else if (luku4 >= luku3 && luku4 > luku5) 
                {
                    Console.WriteLine("toinen luku on isoin");
                }
                else if (luku5 >= luku3 && luku5 > luku3) 
                {
                    Console.WriteLine("kolmas luku on isoin");
                }

            }
            else
            {
                Console.WriteLine("Virheellinen syöte");
            }

            // 4
            Console.WriteLine("Mikä on ikäsi");
            bool validInput6 = int.TryParse(Console.ReadLine(), out int luku6);

            if (validInput6)
            {
                if (luku6 >= 18)
                {
                    Console.WriteLine("Olet aikuinen");
                }
                else if (luku6 < 18)
                {
                    Console.WriteLine("Et ole aikuinen");
                }
            }
            else { Console.WriteLine("Virheellinen syöte"); }

            // 5
            Console.WriteLine("kerro pistemäärä");
            bool validInput7 = int.TryParse(Console.ReadLine(), out int luku7);
            int min = 0;
            int max = 100;
            if (validInput7) 
            {
                if (luku7 < min)
                {
                    luku7 = min;
                    Console.WriteLine("arvosana on "+(luku7));
                }
                else if (luku7 > max)
                {
                    luku7 = max;
                    Console.WriteLine("arvosana on "+(luku7));
                }
                else 
                {
                    Console.WriteLine("arvosana on "+(luku7));
                }
            }
            else { Console.WriteLine("Virheellinen syöte"); }

            // 6
            Console.WriteLine("Anna kolme sivun pituutta");
            bool validInput8 = int.TryParse(Console.ReadLine(), out int luku8);
            bool validInput9 = int.TryParse(Console.ReadLine(), out int luku9);
            bool validInput10 = int.TryParse(Console.ReadLine(), out int luku10);
            if (validInput8 && validInput9 && validInput10)
            {
                if ((luku8 + luku9) > luku10)
                {
                    Console.WriteLine("pituudet toimivat kolmiona");
                }
                else if ((luku9 + luku10) > luku8) 
                {
                    Console.WriteLine("pituudet toimivat kolmiona");
                }
                else if (((luku8 + luku10) > luku9)) 
                {
                    Console.WriteLine("pituudet toimivat kolmiona");
                }
                else 
                {
                    Console.WriteLine("pituudet eivät toimi kolmiona");
                }
            }
            else { Console.WriteLine("Virheellinen syöte"); }

            // 7
            Console.WriteLine("Anna kaksi merkkijonoa");
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            if (line1 == line2) 
            {
                Console.WriteLine("merkkijonot ovat samoja");
            }
            else
            {
                Console.WriteLine("merkkijonot eivät ole samoja");
            }
            
            
            // 8
            Console.WriteLine("Valitse toiminto:");
            Console.WriteLine("1. Eläin nimet");
            Console.WriteLine("2. Planeettojen nimet");

            bool validInput11 = int.TryParse(Console.ReadLine(), out int luku11);
            if (validInput11)
            {
                if (luku11 == 1)
                {
                    string animals = "Kissa, Koira, Hevonen";
                    Console.WriteLine(animals);
                }
                else if (luku11 == 2)
                {
                    Console.WriteLine("Merkurius, Venus, Maapallo, Mars, Jupiter, Saturnus, Uranus, Neptunus, Pluto");
                }
                else
                {
                    Console.WriteLine("Virheellinen syöte. Valitse 1 tai 2");
                }

            }
            else 
            {
                Console.WriteLine("Virheellinen syöte.");
            }
            
            // 9 
            Console.WriteLine("Anna numero 1-7");
            string day1 = "Maanantai";
            string day2 = "Tiistai";
            string day3 = "Keskiviikko";
            string day4 = "Torstai";
            string day5 = "Perjantai";
            string day6 = "Lauantai";
            string day7 = "Sunnuntai";
            bool validInput12 = int.TryParse(Console.ReadLine(),out int luku12);
            if (validInput12)
            {
                if (luku12 > 7)
                {
                    Console.WriteLine("Virheellinen syöte. Anna luku 1-7");
                }
                switch (luku12)
                {
                    case 1:
                        Console.WriteLine("Päivä on " + (day1));
                        break;

                    case 2:
                        Console.WriteLine("Päivä on " + (day2));
                        break;

                    case 3:
                        Console.WriteLine("Päivä on " + (day3));
                        break;

                    case 4:
                        Console.WriteLine("Päivä on " + (day4));
                        break;

                    case 5:
                        Console.WriteLine("Päivä on " + (day5));
                        break;

                    case 6:
                        Console.WriteLine("Päivä on " + (day6));
                        break;

                    case 7:
                        Console.WriteLine("Päivä on " + (day7));
                        break;
                }
            }
            else { Console.WriteLine("Virheellinen syöte."); }

            // 10
            Console.WriteLine("Anna kaksi lukua.");
            bool validInput13 = int.TryParse(Console.ReadLine(), out int luku13);
            bool validInput14 = int.TryParse(Console.ReadLine(), out int luku14);
            Console.WriteLine("Mitä haluat tehdä lukujen kanssa? Yhteenlasku, Erotus, Kertaus vai Jakolasku?");
            string laskutapa = Console.ReadLine();
                
            if (validInput13 && validInput14)
            {
                if (laskutapa == "Yhteenlasku")
                {
                    Console.WriteLine("Yhteenlasku on " + (luku13 + luku14));
                }
                else if (laskutapa == "Erotus") 
                {
                    Console.WriteLine("Erotus on "+ (luku13 - luku14));
                }
                else if (laskutapa == "Kertaus") 
                {
                    Console.WriteLine("Kertaus on "+(luku13 * luku14));
                }
                else if (laskutapa == "Jakolasku") 
                {
                    Console.WriteLine("Jakolasku"+(luku13 / luku14));
                }
                else { Console.WriteLine("Virheellinen syöte"); }
            }
            else { Console.WriteLine("Virheellinen syöte"); }

            // 11
            Console.WriteLine("Anna numero 1-12");
            string kausi1 = "Kevät";
            string kausi2 = "Kesä";
            string kausi3 = "Syksy";
            string kausi4 = "Talvi";
            bool validInput15 = int.TryParse(Console.ReadLine(), out int luku15);
            if (validInput15)
            {
                if (luku15 > 12)
                {
                    Console.WriteLine("Virheellinen syöte. Anna luku 1- 12");
                }
                switch (luku15)
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.WriteLine("Kausi on "+(kausi4));
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("Kausi on "+(kausi1));
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Kausi on "+(kausi2));
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("Kausi on "+(kausi3));
                        break;

                }
            }
            else { Console.WriteLine("Virheellinen syöte."); }

            // 12
            string tunnus = "AAAA";
            string ss = "BBBB";

            Console.WriteLine("Anna käyttäjätunnus:");
            string tunnus2 = Console.ReadLine();
            Console.WriteLine("Anna salasana:");
            string ss2 = Console.ReadLine();

            if (tunnus2 == tunnus && ss2 == ss)
            {
                Console.WriteLine("Pääsy");
            }
            else 
            {
                Console.WriteLine("Pääsy kielletty");
            }

            // 13
            Console.WriteLine("Anna kolmiolle kolme eri pituutta");
            bool validInput16 = int.TryParse(Console.ReadLine(), out int luku16);
            bool validInput17 = int.TryParse(Console.ReadLine(), out int luku17);
            bool validInput18 = int.TryParse(Console.ReadLine(), out int luku18);

            if (validInput16 && validInput17 && validInput18)
            {
                if ((luku16 + luku17) > luku18 && (luku16 + luku18) > luku18 && (luku17 + luku18) > luku16)
                {
                    if (luku16 == luku17 && luku16 == luku18)
                    {
                        Console.WriteLine("Kolmio on tasasivuinen");
                    }
                    else if (luku16 == luku17 && luku16 != luku18 && luku17 != luku18 || luku17 == luku18 && luku17 != luku16 && luku18 != luku16 || luku16 == luku18 && luku16 != luku17 && luku18 != luku17)
                    {
                        Console.WriteLine("Kolmio on tasakylkinen");
                    }
                    else if ((luku16 * luku16 + luku17 * luku17) == luku18 * luku18 || (luku16 * luku16 + luku18 * luku18) == luku17 * luku17 || (luku17 * luku17 + luku18 * luku18) == luku16 * luku16)
                    {
                        Console.WriteLine("Kolmio on suorakulmio");
                    }
                    else
                    {
                        Console.WriteLine("Kolmio on epäsäännöllinen");
                    }
                }
                else
                {
                    Console.WriteLine("Sivuista ei voi tehdä kolmiota");
                }
                // 14
                Console.WriteLine("Anna x ja y kordinaatit");
                bool validInput19 = int.TryParse(Console.ReadLine(), out int x);
                bool validInput20 = int.TryParse(Console.ReadLine(), out int y);
                if (validInput19 && validInput20)
                {
                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine("Piste on oikeassa yläkulmassa (Ensimmäinen neljäs)");
                    }
                    else if (x < 0 && y > 0)
                    {
                        Console.WriteLine("Piste on vasemmalla yläkulmassa (Toinen neljäs)");
                    }
                    else if (x < 0 && y < 0)
                    {
                        Console.WriteLine("Piste on vasemmalla alakulmassa (Kolmas neljäs)");
                    }
                    else if (x > 0 && y < 0) 
                    {
                        Console.WriteLine("Piste on oikealla alakulmassa (Neljäs neljäs)");
                    }
                }
            }
        }
    }
}
