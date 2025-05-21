using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // 2
            for (int i = 0; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // 3 
            for (int i = 0; i <= 100; i += 1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // 4
            for (int i = 0; i <= 5; i++)
            {
                switch (i)
                {
                    case 1: Console.WriteLine("*"); break;
                    case 2: Console.WriteLine("**"); break;
                    case 3: Console.WriteLine("***"); break;
                    case 4: Console.WriteLine("****"); break;
                    case 5: Console.WriteLine("*****"); break;
                }
            }
            Console.WriteLine();

            // 5
            int luku1 = 1;
            int luku2 = 2;
            int luku3 = 3;
            int luku4 = 4;
            int luku5 = 5;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((luku1) + " " + (luku2) + " " + (luku3) + " " + (luku4) + " " + (luku5));
                luku1 += 1;
                luku2 += 2;
                luku3 += 3;
                luku4 += 4;
                luku5 += 5;
            }
            Console.WriteLine();

            // 6
            for (int i = 10; i <= 20; i++)
            {
                Console.WriteLine("Luku: " + i);
                Console.WriteLine("Luku neliönä: " + Math.Pow(i, 2));
                Console.WriteLine();
            }

            // 7
            for (int i = 100; i >= 90; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // 8
            Console.WriteLine("Anna luku");
            bool validInput = double.TryParse(Console.ReadLine(), out double luku);
            if (validInput)
            {
                for (int i = 0; i <= 10; i++)
                {
                    double percent = 0.05;
                    Console.WriteLine("Vuosi " + (i) + ": " + (luku));
                    luku = (luku + (luku * percent));
                }
            }
            Console.WriteLine();

            // 9
            int[] arr1 = { 2, 3, 4, 5, 6 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr1[i]);
            }


            // 10
            Console.WriteLine("Anna viisi kokonaislukua");

            bool validInput1 = int.TryParse(Console.ReadLine(), out int num1);
            bool validInput2 = int.TryParse(Console.ReadLine(), out int num2);
            bool validInput3 = int.TryParse(Console.ReadLine(), out int num3);
            bool validInput4 = int.TryParse(Console.ReadLine(), out int num4);
            bool validInput5 = int.TryParse(Console.ReadLine(), out int num5);

            int[] arr2 = { num1, num2, num3, num4, num5 };
            Console.WriteLine(arr2[0] + " " + arr2[1] + " " + arr2[2] + " " + arr2[3] + " " + arr2[4]);
            Console.WriteLine();

            // 11
            int[] arr3 = { 1, 8, 5, 7, 3 };
            int max = arr3[0];
            int min = arr3[0];

            for (int i = 0; i > 6; i++)
            {
                if (arr3[i] > max)
                {
                    max = arr3[i];
                }
                if (i == 5)
                {
                    Console.WriteLine(max);
                }
            }

            // 12
            int[] arr4 = { 2, 4, 7, 7, 9, 12 };
            double avr = arr4.Average();
            Console.WriteLine(avr);
            Console.WriteLine();

            // 13
            int[] arr5 = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < 5; i++)
            {
                Array.Reverse(arr5);
                Console.WriteLine(arr5[i]);
            }

            // 14
            int check = 5;
            int[] arr6 = { 1, 8, 5, 4, 2 };
            bool loytyi = false;

            for (int i = 0; i < 5; i++)
            {
                if (check == arr6[i])
                {
                    loytyi = true;
                    break;
                }

            }
            Console.WriteLine("Löytyi: " + loytyi);

            // 15
            int[] arr7 = { 1, 2, 3, 4, 5 };
            int[] arr8 = { 2, 3, 4, 5, 6 };
            int[] arr9 = new int[arr7.Length + arr8.Length];

            Array.Copy(arr7, arr9, arr7.Length);
            Array.Copy(arr8, 0, arr9, arr7.Length, arr8.Length);
            for (int i = 0; i < arr9.Length; i++)
            {
                Console.WriteLine(arr9[i]);
            }
            Console.WriteLine();

            // 16
            int[,] arr10 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < arr10.GetLength(0); i++)
            { 
            for (int j = 0; j < arr10.GetLength(1); j++)
            {
                Console.Write(arr10[i, j]) ;
               
            }
            Console.WriteLine();
            }
            Console.WriteLine();

            // 17
            int[] arr11 = {2, 3, 1, 7, 5, 3, 9, 0, 3, 4 };
            Array.Sort(arr11);
            for (int i = 0; i < arr11.Length; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}