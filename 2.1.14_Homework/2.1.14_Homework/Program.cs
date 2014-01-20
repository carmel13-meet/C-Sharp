using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._1._14_Homework
{
    class Program
    {
        public static int checkNum(int num)
        {
            int temp = num;
            int count = 0;
            int countF = 0;
            int countT = 0;
            int sif = num % 10;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            while (temp > 9)
            {
                temp = temp / 10;
                if (sif != temp % 10)
                    countT++;
                else
                    countF++;
                sif = temp % 10;
            }

            if (countT == (count-1))
                return 1;
            else
                return 0;
            
        }
        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            while (checkNum(num) != 1)
            {
                count++;
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Until {0}, {1} numbers were entered", num, count);
        }
    }
}
