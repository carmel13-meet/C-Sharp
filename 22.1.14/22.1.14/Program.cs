using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22._1._14
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] ot = new char[100];
            //int countLower = 0;
            //int countUpper = 0;
            //int[] mone1 = new int[26];
            //Random rand = new Random();
            //for (int i = 0; i < 122; i++)
            //{
            //    int num = rand.Next(65, 91);
            //    while (num >= 91 && num <= 97)
            //    {
            //        num = rand.Next(65, 91);
            //    }
            //    ot[i] = (char)num;
            //}
            //for (int i = 0; i < ot.Length; i++)
            //{
            //    if ((int)(ot[i]) >= 65 && (int)(ot[i]) <= 91)
            //        countUpper++;
            //    if ((int)(ot[i]) >= 97 && (int)(ot[i]) <= 122)
            //        countLower++;
            //}
            //for (int i = 0; i < 26; i++)
            //{
            //    mone1[i] = 0;
            //}
            //for (int i = 0; i < 100; i++)
            //{
            //    mone1[(int)(ot[i]) - 65] += '*';
            //}
            //for (int i = 0; i < mone1.Length; i++)
            //{
            //    Console.Write((char)(65 + i) + "\t");
            //    for (int j = 0; j < mone1[i]; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            Random rand = new Random();
            double[] mone = new double[6];
            for (int i = 1000; i <= 1000000; i*=10)
            {
                    for (int j = 0; j < 6; j++)
                    {
                        mone[j] = 0;
                    }
                    for (int j = 0; j < i; j++)
                    {
                        int cube = rand.Next(1, 7);
                        mone[cube - 1]++;
                    }
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine("{0} >>>> {1} is far from the opinion by {2}", j + 1, mone[j], Math.Abs(mone[j] - (i / 6)));
                    }
                Console.WriteLine();
                Console.WriteLine();
            }



        }
    }
}
