using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16._12._13
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num=0;
            //int num1=1;
            //int num2=0;
            //for(int i=1; i<=20; i++)
            //{
            //    num2 = num + num1;
            //    num = num1;
            //    num1 = num2;
                
            //}
            //Console.WriteLine(num2);

            //for (int e = 1; num2 <= 20000; e++)
            //{
                
            //    num = num1;
            //    num1 = num2;
            //    num2 = num + num1;
            //}
            //Console.WriteLine(num2);

            //Console.BackgroundColor = ConsoleColor.Cyan;
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Clear();

            //for (int a = 1; a <= 4; a++)
            //{
            //    for (int b = 1; b <= 4; b++)
            //    {
            //        for (int c = 1; c <= 4; c++)
            //        {
            //            for (int d = 1; d <= 4; d++)
            //            {
            //                if ((a != b) && (a != c) && (a != d) && (b != c) && (b != d) && (c != d))
            //                {
            //                    Console.WriteLine("{0}{1}{2}{3}", a, b, c, d);
            //                }
            //            }
            //        }
            //    }

            double num = 1;
            for (int i = 1; i <= 50; i++)
            {
                num = num + Math.Pow(2, -i);
                Console.WriteLine(num);
            }
            

                
               
            

        }
    }
}
