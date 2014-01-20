using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._1._14
{
    class Program
    {
        public static int checkMinSif(int num)
        {
            int minSif = num % 10;
            return minSif;
        }
        public static int checkMaxSif(int num)
        {
            while (num > 9)
            {
                num = num / 10;
            }
            return num;
        }
        public static int createNum(int num)
        {
            int newNum = (checkMaxSif(num) + checkMinSif(num)) % 10;
            int newNum2 = num * 10 + newNum;
            return newNum2;
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                int num2 = createNum(num);
                int num3 = createNum(num2);
                Console.WriteLine("The new number is {0}", num3);
            }
        }
    }
}
