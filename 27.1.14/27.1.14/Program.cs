using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _27._1._14
{
    class Program
    {
        public static int[] DoTheJob(int[] a)
        {
            //הפעולה תקבל כקלט מערך מונים ריק
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            while (num >= 1 && num <= 30)
            {
                a[num - 1]++;
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());
            }
            return a;
            //הפעולה תחזיר את מספר המופעים של כל מספר במערך
        }
        static void Main(string[] args)
        {
            //תרגיל כיתה

            //Console.WriteLine("What's the length of your array ? ");
            //int length = int.Parse(Console.ReadLine());

            //int[] countArray = new int[30];
            //for (int i = 0; i < countArray.Length; i++)
            //{
            //    countArray[i] = 0;
            //}
            //countArray = DoTheJob(countArray);
            //Console.WriteLine();
            //for (int i = 0; i < countArray.Length; i++)
            //{
            //    if (countArray[i] > 0)
            //    {
            //        for (int j = 0; j < countArray[i]; j++)
            //        {
            //            Console.WriteLine(i+1);
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //תרגיל כיתה- בול פגיעה

            int countBool = 0;
            int countHit = 0;
            int tries = 0;
            int[] a = new int[4];
            int[] b = new int[4];
            Random randNum = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 0;
                b[i] = 0;
            }
            a[0] = randNum.Next(1, 10);
            for (int i = 1; i < a.Length; i++)
            {
                a[i] = randNum.Next(1, 10); 
                while (a[i] == a[i-1])
                    a[i] = randNum.Next(1, 10); 
            }
            Console.ForegroundColor = ConsoleColor.Green;
            while (tries <= 10 && countBool < 4)
            {
                tries++;
                countBool = 0;
                countHit = 0;
                for (int i = 0; i < b.Length; i++)
                {
                    Console.Write("Enter a number: ");
                    b[i] = int.Parse(Console.ReadLine());
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (i == j)
                        {
                            if (b[i] == a[j])
                                countBool++;
                        }
                        else
                        {
                            if (b[i] == a[j])
                                countHit++;
                        }
                    }
                }
                Console.WriteLine("{0} Bools, {1} Hits ", countBool, countHit);
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (countBool == 4)
                Console.WriteLine("You've won ! ");
            else
            {
                Console.WriteLine("You've lost ! ");
                Console.Write("The random array was: ");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write("{0} ", a[i]);
                }
            }

            
        }
    }
}
