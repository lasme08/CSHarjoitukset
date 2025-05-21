using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // 1
            List<int> list1 = new List<int>() { 1, 2, 6, 7, 5, 8, 9, 10 };
            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // 2
            List<int> list2 = new List<int>() {1, 2, 3, 4, 5, 6,7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            list2.Remove(1);
            list2.Remove(3);
            list2.Remove(5);
            list2.Remove(7);
            list2.Remove(9);
            list2.Remove(11);
            list2.Remove(13);
            list2.Remove(15);
            list2.Remove(17);
            list2.Remove(19);
            
            foreach (int i in list2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // 3
            Console.WriteLine("Syötä viisi kokonaislukua");
            bool validInput = int.TryParse(Console.ReadLine(), out int luku1);
            bool validInput2 = int.TryParse(Console.ReadLine(),out int luku2);
            bool validInput3 = int.TryParse(Console.ReadLine(), out int luku3);
            bool validInput4 = int.TryParse(Console.ReadLine(), out int luku4);
            bool validInput5 = int.TryParse(Console.ReadLine(), out int luku5);

            if (validInput && validInput2 && validInput3 && validInput4 && validInput5)
            {
                List<int> list3 = new List<int>() { luku1, luku2, luku3, luku4, luku5 };
                
                Console.WriteLine("Isoin: "+ list3.Max());
                Console.WriteLine("Pienin: "+ list3.Min());

            }
            else { Console.WriteLine("Virheellinen syöte"); }

            // 4
            List<string> list = new List<string>() { "Jonas", "Elias", "Konsta", "Valtteri" };
            Console.WriteLine("Mikä on etunimesi?");
            string input = Console.ReadLine();
            if (list.Contains(input))
            {
                Console.WriteLine("Löytyi");
            }
            else 
            {
                Console.WriteLine("Ei löytynyt");
            }
            Console.WriteLine();

            // 5
            List<string> list4 = new List<string>() {"Jonas", "Aaro", "Jasper", "Mathias", "Ben" };
            list4.Sort();
            foreach (string a in list4) 
            {
                Console.WriteLine($"{a}");
            }

            // 6
            List<int> list5 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in list5)
            {
                Console.WriteLine(i);
            }
            list5.Reverse();
            Console.WriteLine();
            foreach (int i in list5) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // 7
            var rand = new Random();  

            List<int> list6 = new List<int>() {rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10), rand.Next(1, 10), };
            Console.WriteLine("Anna kokonaisluku");
            bool validInput6 = int.TryParse(Console.ReadLine(), out int luku6);
            int count = 0;

            if (validInput6) 
            {
                for (int i = 0; i < list6.Count; i++)
                {
                    if (list6[i] == luku6) 
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Luku oli listassa " + count + " kertaa.");
            Console.WriteLine();

            // 8
            List<string> list7 = new List<string>() { "Ben", "Sam", "Robin", "Steve" };
            foreach (string a in list7)
            {
                Console.WriteLine($"{a}");
            }
            Console.WriteLine("Kerro , minkä nimen haluat poistaa listalta");
            string nameremove = Console.ReadLine();
            if (list7.Contains(nameremove))
            {
                list7.Remove(nameremove);
            }
            Console.WriteLine("Anna listalle uusi nimi");
            string nameadd = Console.ReadLine();
            list7.Add(nameadd);
            foreach (string i in list7) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // 9
            List<int> list8 = new List<int>() { 1, 2, 3, 4, 5, 6, };
            List<int> list9 = new List<int>() { 7, 0, 9, 4, 8, 6, };
            List<int> ulist = list8.Union(list9).ToList();
            foreach (int i in list8) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // 10 
            List<int> list10 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            List<int> list11 = new List<int>(list10) { };
            list10.Add(11);
            list10.Add(12);
            list10.Add(13);
            list10.Add(14);
            Console.Write("Alkuperäinen: ");
            foreach (int i in list10)
                { Console.Write(i+" "); }
            Console.WriteLine();
            Console.Write("Kopio: ");
            foreach (int i in list11)
                { Console.Write(i+" "); }
            Console.WriteLine();
            
            Console.Clear();

            // 11
            List<string> list12 = new List<string>(); 
            while (true) 
            {
                Console.WriteLine("Mitä haluat tehdä Kauppalistalla?");
                Console.WriteLine("1. Lisää esine");
                Console.WriteLine("2. Poista esine");
                Console.WriteLine("3. Näytä lista");
                Console.WriteLine("4. Poistu");

                bool validInput7 = int.TryParse(Console.ReadLine(), out int luku7);
                if (validInput7 && luku7 == 1 || luku7 == 2 || luku7 == 3 || luku7 == 4)
                {
                    Console.Clear();
                    if (luku7 == 1)
                    {
                        Console.WriteLine("Mitä haluat lisätä listaan?");
                        string additem = Console.ReadLine();
                        list12.Add(additem);
                        Console.Clear();
                        Console.WriteLine("Esine on lisätty!");
                        Console.WriteLine();
                    }
                    else if (luku7 == 2)
                    {
                        Console.WriteLine("Mitä haluat poistaa listasta");
                        string removeitem = Console.ReadLine();
                        list12.Remove(removeitem);
                        Console.Clear();
                        Console.WriteLine("Esine on poistettu!");
                        Console.WriteLine();
                    }
                    else if (luku7 == 3)
                    {
                        Console.Clear();
                        foreach (string item in list12)
                        {
                            
                            Console.WriteLine($"{item}");
                            
                        }
                        Console.WriteLine();
                    }
                    else if (luku7 == 4)
                    {
                        Console.WriteLine("Ok!");
                        break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Virheellinen syöte. Anna luku 1-4");
                    Console.WriteLine();
                }
            }
        }
    }
}
