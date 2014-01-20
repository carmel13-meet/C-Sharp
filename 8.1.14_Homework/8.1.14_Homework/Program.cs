using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8._1._14_Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            // תרגיל 1 א
            //int[] m = { 0, 0, 0, 0 };
            //int m1, m2;
            //m[0] = int.Parse(Console.ReadLine());
            //m[1] = int.Parse(Console.ReadLine());
            //m1 = int.Parse(Console.ReadLine());
            //m2 = int.Parse(Console.ReadLine());
            //m[1] = 10 * m[1];
            //m[2] = m1 + m2;
            //m1 = m[1];
            //m[3] = m[1] + m[2] + m[3];
            //Console.WriteLine("m1 = {0}, m2 = {1}, m[0] = {2}, m[1] = {3}, m[2] = {4}, m[3] = {5}", m1, m2, m[0], m[1], m[2], m[3]);

            int temp = 0;
            int temp2 = 0;
            int countT = 1;
            int avg = 0; 
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter number #{0}: ", i+1);
                int num = int.Parse(Console.ReadLine());
                if (i == 0)
                    temp = num;
                if (i == 1)
                    temp2 = num;
                avg = (temp + temp2) / 2;
                if (num < avg)
                    countT++;
            }
            Console.WriteLine("{0} numbers are smaller than the average of the first two numbers", countT);
            
    
        }
    }
}
