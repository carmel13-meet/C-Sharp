using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13._1._14
{
    class Program
    {
        static void Main(string[] args)
        {
            //int Ariel = 0;
            //int Carmel = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Enter a number {0}: ", (i + 1));
            //    int no = int.Parse(Console.ReadLine());
            //    if (no > Ariel)
            //        Ariel = no;
            //    else
            //    {
            //        if (no > Carmel)
            //            Carmel = no;
            //    }
            //}
            //Console.WriteLine("max no. is {0} and second max no. is {1}", Ariel, Carmel);
            Console.WriteLine("were up all night for SQL");
            int [] a = new int [4];
            Random randNum = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] =((1 - i) * 3) + 3;
                Console.WriteLine(a[i]);
            }
        }
    }
}
