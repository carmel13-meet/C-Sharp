using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _26._12._13
{
    class Program
    {
        public static int RandomBD(int num1, int num2)
        {
            Random randNum = new Random();
            int newNum = randNum.Next(Math.Min(num1, num2), (Math.Max(num1, num2)+1));
            return newNum;
        }
        static void Main(string[] args)
        {
          
            Console.Write("Enter number #1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number #2: ");
            int num2 = int.Parse(Console.ReadLine());
            while (num1 != -999 && num2 != -999)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Enter number #1: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter number #2: ");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("The new number is {0}", RandomBD(num1, num2));
                }
              
            }
        }
    }
}
