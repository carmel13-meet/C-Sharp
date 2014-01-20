using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13._1._14_Homework
{
    class Program
    {
        public static int[] InputN(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter number:");
                int no = int.Parse(Console.ReadLine());
                a[i] = no;
            }
            return a;
        }
        static void Main(string[] args)
        {
            //תרגיל 16
            int[] a = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter a letter: ");
                a[i] = char.Parse(Console.ReadLine());
            }
            int count = 0;
            for (char c = 'a'; c <= 'z'; c++)
            {
                count = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == c)
                        count++;
                }
                if (count == 0)
                    Console.WriteLine(c);
            }
            for (char c = 'A'; c <= 'Z'; c++)
            {
                count = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == c)
                        count++;
                }
                if (count == 0)
                    Console.WriteLine(c);
            }

            //תרגיל 17
            //a = InputN(a);
            //int[] b = new int[a.Length];
            //for (int i = 0; i < b.Length; i++)
            //{
            //    b[i] = a[i] * 2;
            //}
        }
    }
}
