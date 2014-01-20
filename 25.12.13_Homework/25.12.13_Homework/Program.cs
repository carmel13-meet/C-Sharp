using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _25._12._13_Homework
{
    class Program
    {
        public static int CommonDenominator(int num1, int num2, int num3, int num4)
        {
            int i = num1;
            while (!(i % num1 == 0 && i % num2 == 0 && i % num3 == 0 && i % num4 == 0))
            {
                //if (i % num1 == 0 && i % num2 == 0 && i % num3 == 0 && i % num4 == 0)
                    //break;
                i++;
            }
            return i;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number #1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number #2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter number #3: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Enter number #4: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("The common denominator of these numbers is {0}", CommonDenominator(num1, num2, num3, num4));
        }
    }
}
