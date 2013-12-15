using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11._12._13
{
    class Program
    {
        static void Main(string[] args)
        
        {
            double a = double.Parse(Console.ReadLine());
            double x = a;
            double b = 1;
            while (Math.Abs(a-b)>0.0001)
            {
                a = (a + b) / 2;
                b = x / a;
            }
            Console.WriteLine("Round = " + Math.Round(a));
            
        }
    }
}
