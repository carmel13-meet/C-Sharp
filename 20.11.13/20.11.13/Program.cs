using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20._11._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Homie give me a number: ");

            //for (int i = 1; i <= 1000; i++)
            //{

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == 1)
                Console.Write("This is mispar rishoni");
            else
                Console.Write("This is not mispar rishoni");

            //}
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
