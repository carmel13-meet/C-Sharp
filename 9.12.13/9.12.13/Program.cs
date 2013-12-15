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
            int computers = int.Parse(Console.ReadLine());
            Console.Write("English grade: "); 
            int english = int.Parse(Console.ReadLine());
            Console.Write("Math grade: "); 
            int math = int.Parse(Console.ReadLine());
            int average = 0;
            int count = 0;
            int smallestComputers = 100;
            int count2 = 0;
            int highestMath = 0;
            int count3 = 0;
            int sumEnglish = 0;
            int averageEnglish = 0;
            while ((computers >= 0 && computers <= 100) && (english >= 0 && english <= 100) && (math >= 0 && math <= 100))
            {
                count++;
                average = (computers + english + math) / 3;
                if (average < 55)
                {
                    Console.WriteLine("Look at your grades!! an average of {0}??? are you kidding me?!?! , You have failed...", average);
                }
                if (computers < smallestComputers)
                {
                    smallestComputers = computers;
                    count2 = count;
                }
                if (math > highestMath)
                {
                    highestMath = math;
                    count3 = count;
                }
                sumEnglish += english;
                Console.Write("Would you like to continue ? (Y/N) "); string answer = Console.ReadLine();
                if (answer == "Y" || answer == "y")
                    continue;
                if (answer == "n" || answer == "N")
                    break;
            }
            averageEnglish = sumEnglish / count;
            Console.WriteLine("The student who got the lower grade in computers is student #{0}, his grade was {1}", count2, smallestComputers);
            Console.WriteLine("The highest grade in math is {0}", highestMath);
            Console.WriteLine("The average of english is {0}", averageEnglish);
           
            
        }
    }
}
