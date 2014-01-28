using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23._1._14_Homework
{
    class Program
    {
        public static void Targil20()
        {
            Console.WriteLine("What's the length of your array ? ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] a = new int[length];
            int[] b = new int[length];
            int[] c = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter a number: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter a number: ");
                b[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                if (a[i] > b[i])
                    c[i] = a[i];
                if (a[i] < b[i])
                    c[i] = b[i];
                if (a[i] == b[i])
                    c[i] = 0;
                Console.WriteLine("c[{0}] = {1} ", i, c[i]);
            }
        }

        public static void Targil21()
        {
            int countNegative = 0;
            int countPositive = 0;
            Console.WriteLine("What's the length of your array ? ");
            int length = int.Parse(Console.ReadLine());
            int[] a = new int[length];
            int[] b = new int[length];
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                b[i] = 0;
            }
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter a number: ");
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] < 0)
                {
                    b[countNegative] = a[i];
                    countNegative++;
                }
                
            }
            for (int i = 0; i < length; i++)
            {
                    if (a[i] > 0)
                    {
                        b[countNegative + countPositive] = a[i];
                        countPositive++;
                    }      
            }
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("b[{0}] = {1} ", i, b[i]);
            }

        }

        static void Main(string[] args)
        {
            Targil21();
        }
    }
}
