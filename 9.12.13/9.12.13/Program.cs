using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9._12._13
{
    class Program
    {
        static void Main(string[] args)
        {
            //int mod = 0;
            //int counter = 0;
            //int no1 = int.Parse(Console.ReadLine());
            //int no2 = int.Parse(Console.ReadLine());
            //while (no1 > 0)
            //{
            //    no1 -= no2;
            //    if (no1 < 0)
            //        break;
            //    if (no1 < no2)
            //        mod += no1;
            //    counter++;
            //    //Console.WriteLine("no1 = {0} , no2 = {1} , counter = {2}", no1, no2, counter);
            //}
            //Console.WriteLine("result = {0}", counter);
            //Console.WriteLine("The mod is {0}", mod);

            Console.Write("Computer grade: "); 
            int comp = int.Parse(Console.ReadLine());
            Console.Write("English grade: "); 
            int eng = int.Parse(Console.ReadLine());
            Console.Write("Math grade: "); 
            int math = int.Parse(Console.ReadLine());
            int avg = 0;
            int count = 0;
            int minComp = 100;
            int count2 = 0;
            int maxMath = 0;
            int count3 = 0;
            int sumEng = 0;
            int avgEng = 0;
            while ((comp >= 0 && comp <= 100) && (eng >= 0 && eng <= 100) && (math >= 0 && math <= 100))
            {
                count++;
                avg = (comp + eng + math) / 3;
                if (avg < 55)
                {
                    Console.WriteLine("Look at your grades!! an average of {0}??? are you kidding me?!?! , You have failed...", avg);
                }
                if (comp < minComp)
                {
                    minComp = comp;
                    count2 = count;
                }
                if (math > maxMath)
                {
                    maxMath = math;
                    count3 = count;
                }
                sumEng += eng;
                Console.Write("Would you like to continue ? (Y/N) "); string answer = Console.ReadLine();
                if (answer == "Y" || answer == "y")
                    continue;
                if (answer == "n" || answer == "N")
                    break;
            }
            avgEng = sumEng / count;
            Console.WriteLine("The student who got the lower grade in computers is student #{0}, his grade was {1}", count2, minComp);
            Console.WriteLine("The highest grade in math is {0}", maxMath);
            Console.WriteLine("The average of english is {0}", avgEng);
           
            
        }
    }
}
