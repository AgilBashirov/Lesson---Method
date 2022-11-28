using System;

namespace Lesson___Method
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            #region Goto
            //level1:
            //    Console.WriteLine("10 reqemini daxil edin");
            //    string numberStr = Console.ReadLine();
            //    int number = int.Parse(numberStr);

            //    if (number != 10)
            //    {
            //        goto level1;
            //    }
            //    else
            //    {
            //        Console.WriteLine("duzgun daxil edildi");
            //    }
            #endregion

            #region Method

            //int a = 5;
            //string word = "anything";
            //int b = 6;
            //int c = a + b;

            //Sum(a,b);

            //int d = 10;
            //int e = 25;
            //int f = d + e;

            //for (int i = 0; i < 50; i++)
            //{
            //    if (i == 10)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            //int result = Sum(10, 5);
            //Console.WriteLine(Sum(10, 5));

            //string fullname = Join("Alik", "Eyvazli", "Bilal");
            //Console.WriteLine(fullname);

            //Sum(15555, 66565, 98989);
            //Sum(5,50);
            //Console.WriteLine(Sum("5", 15));
            #endregion

            #region Var and Dynamic
            //var i = "khdfjk";
            //i = 5;
            //i = "salam";

            //dynamic b = 5;
            //b = "5";
            #endregion

            int[] a = { 10, 20, 30 };
            //int[] b = a;

            //b[0] = 19;

            //Console.WriteLine(a[0]);
            //Console.WriteLine(b[0]);

            //int a = 5;
            //int b = a;
            //b = 33;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            GetArray();

        }
        static void GetArray(params string[] arr)
        {
        }
        static void FindNumberInArray(int[] arr, int n)
        {
            bool isExist = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == n)
                {
                    Console.WriteLine("Tapildi");
                    isExist = true;
                    break;
                }
            }

            if (isExist != true)
            Console.WriteLine("Tapilmadi");
        }
        static int Sum(string a, int b)
        {
            return int.Parse(a) + b;
        }
        static int Sum(int a, int b)
        {
            int c =  a + b;
            return c;
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Show()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 10)
                {
                    return;
                }
            }

        }
        static string Join(string ad, string soyad, string ataAdi)
        {
            return $"{ad} {soyad} {ataAdi} oglu";
        }
    }
}
