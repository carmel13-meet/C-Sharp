using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _26._12._13_Homework
{
    class Program
    {
        public static int howEven(int num)
        {
            int countEven = 0;
            while (num > 0)
            {
                if ((num % 10) % 2 == 0)
                {
                    countEven++;
                }
                num = num / 10;
            }
            return countEven;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int even = howEven(num);
            int maxEven = 0;
            int whatNum = 0;
            while (num != 0)
            {
                if (even > maxEven)
                {
                    maxEven = even;
                    whatNum = num;
                }
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                even = howEven(num);
            }
            Console.WriteLine("The number which has the most even digits is {0}", whatNum);
            
        }
    }
}
