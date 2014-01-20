using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20._1._14
{
    class Program
    {
        public static int[] Input(int[] a)
        {
            //טענת כניסה: הפעולה תקבל מערך ריק בשם a ותכניס אליו נתונים מהמשתמש
            //טענת יציאה: הפעולה תחזיר מערך a
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter a number: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        public static int[] Unit(int[] a, int[] b, int[] c)
        {
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                c[a.Length + i] = b[i];
            }
            return c;
        }
        public static void Print(int[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
        static void Main(string[] args)
        {
            //Console.Write("What's the length of a[] ? ");
            //int lengthA = int.Parse(Console.ReadLine());
            //int[] a = new int[lengthA];
            //Console.Write("What's the length of b[] ? ");
            //int lengthB = int.Parse(Console.ReadLine());
            //int[] b = new int[lengthB];
            //a = Input(a);
            //b = Input(b);
            //int[] c = new int[a.Length + b.Length];
            //c = Unit(a, b, c);
            //Print(c);

            int count = 0;
            char[] a = new char[100];
            int[] b = new int[26];
            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                int no = rand.Next(65, 91);
                a[i] = (char)no;
            }
            for (int i = 65; i < 91; i++)
            {
                count = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == (char)i)
                        count++;
                }
                b[i - 65] = count;
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write((char)(i+65) + " --- ");
                for (int j = 0; j < b[i]; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

        }
    }
}
