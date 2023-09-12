using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ardisik(new int[] { 1, 2, 5, 3, 1, 3, 5, 6, 7, 5, 9 }, 1);
            Eleman(new int[] { 6, 4, 9 });
            ListArray(new List<int>() { 3, 6, -2, -5, 7, 3 });
            Baklava(Convert.ToInt32(Console.ReadLine()));
            Console.ReadLine();
            //Console.WriteLine(" Close X");
            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.Write(" " + args[i]);
            //}
            //for (int i = 0; i < args.Length; i++)
            //{
            //    Baklava(Convert.ToInt32(args[i]));
            //}

            //while (true)
            //{
            //    string x = Console.ReadLine();
            //    Baklava(Convert.ToInt32(x));

            //    if (x == "X")
            //    {
            //        Environment.Exit(0);
            //    }
            //}
        }

        public static void Ardisik(int[] a, int kat)
        {
            int[] temp = new int[a.Length];
            int[] tempLost = new int[a.Length];
            int sayac1 = 0;
            int sayac2 = 0;
            temp[sayac1++] = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if ((a[i - 1]) == a[i] - kat)
                {
                    temp[sayac1++] = a[i];
                }
                else
                {
                    for (int j = i; j < a.Length; j++)
                    {
                        if (temp[sayac1 - 1] == a[j] - kat)
                        {
                            temp[sayac1++] = a[j];
                        }
                        else
                        {
                            tempLost[sayac2++] = a[j];
                        }
                        i = j;
                    }
                }
            }

            Console.Write("Dizi :" + temp[0]);
            for (int i = 1; i < sayac1; i++)
            {
                Console.Write(", " + temp[i]);
            }
            Console.Write(" artış sayısı." + kat);
            Console.WriteLine();
            Console.Write("Diziden çıkarılan elemanlar:" + tempLost[0]);
            for (int i = 0; i < sayac2; i++)
            {
                Console.Write(", " + tempLost[i]);
            }
            Console.WriteLine();
        }

        public static void Eleman(int[] a)
        {
            int min = a[0];
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            Console.WriteLine(""+(max-min-a.Length+1));

        }

        public static void Baklava(int sayi)
        {
            sayi = sayi * 2 - 1;
            for (int i = 0; i <= sayi - 2; i++)
            {
                for (int j = 0; j < sayi - i; j++)
                {
                    Console.Write(" ");
                }
                if (i % 2 == 0)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= sayi; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                if (i % 2 != 0)
                {
                    for (int j = 0; j <= sayi - i; j++)
                    {
                        Console.Write("* ");
                    }
                }

                Console.WriteLine();
            }
        }

        public static void ListArray(List<int> list)
        {
            int s1 = 0;
            int s2 = 0;
            int max = list[0] * list[1];

            for (int i = 1; i < list.Count - 1; i++)
            {
                if (list[i] * list[i + 1] > max)
                {
                    max = list[i] * list[i + 1];
                    s1 = list[i];
                    s2 = list[i + 1];
                }
            }

            Console.Write(s1 + " * " + s2 + " = " + max);
        }
    }
}
