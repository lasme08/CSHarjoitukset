using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tietotyypit
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // 1
            const double PI = 3.14159;
            Console.WriteLine("mikä on halkaisijan pituus?");

            bool validInput = double.TryParse(Console.ReadLine(), out double pituus);


            if (validInput)
            {
                double mitta = (pituus * PI);
                Console.WriteLine("ympyrän ympärysmitta on "+(mitta));

            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen pituus");
            }
            // 2
            
            Console.WriteLine("kuinka monta sekuntia esine on ilmassa?");
            bool validInput2 = double.TryParse(Console.ReadLine(), out double s);

            if (validInput2)
            {
                double g = (9.81 + (1 / Math.Pow(s, 2)));
                Console.WriteLine("Asian putoamismatka on "+(1/2*g));
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen ajanmäärä");
            }



            // 3
            Console.WriteLine("Kuinka monta metriä korkea suorakulmio on?");
            bool validInput3 = double.TryParse(Console.ReadLine(), out double korkeus);
            if (validInput3)
            {
                Console.WriteLine("Kuinka monta metriä leveä suorakulmio on");
                bool validInput4 = double.TryParse(Console.ReadLine(), out double leveys);
                if (validInput4)
                {
                    Console.WriteLine("suorakulmion pinta-ala on " + (leveys * korkeus) + " neliömetriä");
                }
                else
                {
                    Console.WriteLine("Virheellinen syöte. Anna kelvollinen leveys");
                }
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen korkeus");
            }
            // 4
            double arvonlisävero = 0.255;
            Console.WriteLine("Mikä on veroton hinta?");
            bool validInput5 = double.TryParse(Console.ReadLine(), out double hinta);
            if (validInput5)
            {
                Console.WriteLine("kokonaishinta on "+(hinta * (1 + arvonlisävero)));
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen hinta");
            }
            // 5
            Double c = 299792458;
            Console.WriteLine("Kerro kuinka monta sekuntia valo liikkuu.");
            bool validInput6 = double.TryParse(Console.ReadLine(),out double sec);
            if (validInput6)
            {
                Console.WriteLine("matkan pituus on " + ((c * sec) / 1000) + " kilometriä");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen määrä");
            }
            // 6
            Console.WriteLine("Kerro lämpötila celsiuksena.");
            bool validInput7 = double.TryParse(Console.ReadLine(), out double celsius);
            if (validInput7)
            {
                Console.WriteLine("Lämpötila fahrenheittina on " + (celsius * (9 / 5) + 32));
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen läämpötila");
            }
            // 7
            Console.WriteLine("Syötä joku numero.");
            bool validInput8 = int.TryParse(Console.ReadLine(), out int secs);
            if (validInput8)
            {
                int hours = (secs / 3600);
                int hoursecs = (secs % 3600);
                int minutes = (secs / 60);
                int minsecs = (secs % 60);


                Console.WriteLine("Aika on " + (hours) + " tuntia " + (minutes) + " minuuttia tai " + (secs) + " sekuntia");
            }
            else
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen sekunti määrä");
            }
            // 8
            Console.WriteLine("Mikä on esineen korkeuden muutos metreinä?");
            bool validInput9 = double.TryParse(Console.ReadLine(), out double h);
            if (validInput9)
            {
                double p = (1.225 / Math.Pow(h, 3));
                double g2 = (9.81 / Math.Pow(1, 2));
                Console.WriteLine("Paineen muutos on "+(p*g2*h));
            }
            else 
            {
                Console.WriteLine("Virheellinen syöte. Anna kelvollinen korkeus");
            }

        }
    }
}
