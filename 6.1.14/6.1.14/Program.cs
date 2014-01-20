using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._1._14
{
    class Program
    {
        public static double[] InputArr(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Enter a number: ");
                a[i] = double.Parse(Console.ReadLine());
            }
            return a; 
        }

        static void Main(string[] args)
        {
            //double avg = 0;
            //int countM = 0;
            //double sum = 0;
            //double[] array1 = new double[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Enter your jumping height student #{0}: ", i+1);
            //    double height = double.Parse(Console.ReadLine());
            //    array1[i] = height;
            //    sum += height;
            //}
            //avg = sum / 10;
            //Console.Write("The students whose jumping height is bigger than the average are: ");
            //for (int i = 0; i < 10; i++)
            //{
               
            //    if (array1[i] > avg)
            //    {
            //        countM++;
            //        Console.Write("{0} ", i+1);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("{0} students have passed the avergae, the average is {1}", countM, avg);

            double[] res = new double [10];
            res = InputArr(res);
            Console.WriteLine();
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }
            Console.ReadLine();
            
            
        }
    }
}

