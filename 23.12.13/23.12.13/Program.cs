using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23._12._13
{
    class Program
    {
        static void Main(string[] args)
        {
            //לולאת do

            //int i = 18;
            //do
            //{
            //    Console.WriteLine(i);
            //    i -= 900;
            //}
            //while (i > 0);

            //הוראת switch

            //Console.Write("What day is today ? ");
            //string day = Console.ReadLine();
            //switch (day)
            //{
            //    case "Sunday":
            //        Console.WriteLine("Hell jesus");
            //        break;
            //    case "Saturday":
            //        Console.WriteLine("Shabat shalom");
            //        break;
            //    default:
            //        Console.WriteLine("You haven't written a day");
            //        break;
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write("Enter your grade: ");
            //    int grade = int.Parse(Console.ReadLine());
            //    switch (grade)
            //    {
            //        case 100:
            //            Console.WriteLine("Very good");
            //            break;
            //        case 90:
            //            Console.WriteLine("Almost very good");
            //            break;
            //        case 80:
            //            Console.WriteLine("Good");
            //            break;
            //        case 70:
            //            Console.WriteLine("Almost good");
            //            break;
            //        case 60:
            //            Console.WriteLine("Enough");
            //            break;
            //        case 50:
            //        case 40:
            //        case 30:
            //        case 20:
            //        case 10:
            //            Console.WriteLine("You have failed");
            //            break;
            //        default:
            //            Console.WriteLine("Your grade is not vaild");
            //            break;
            //    }

            //}

           //תרגיל 32

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter ot: ");
            //char ot = char.Parse(Console.ReadLine());
            //int count = 1;
            //while (name[0] != ot)
            //{
            //    Console.Write("Enter ot: ");
            //    ot = char.Parse(Console.ReadLine());
            //    count++;
            //}
            //Console.WriteLine("The ot is #{0}", count);
            
            //תרגיל 33

            //Console.Write("Enter a number: ");
            //double num = double.Parse(Console.ReadLine());
            //double firstNum = 0;
            //int count = 0;
            //while (num != 0)
            //{
            //    for (int i = 0; i < 2; i++)
            //    {
            //        firstNum = num;
            //        Console.Write("Enter a number: ");
            //        num = double.Parse(Console.ReadLine());
            //    }
            //    if (firstNum > num)
            //        count++;
            //}
            //Console.WriteLine("Count = {0}", count);

            //תרגיל 34

            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //int sif1 = num % 10;
            //int sif2 = num / 10;
            //int sif3 = num / 100;
            //int sif4 = num / 1000;
            //int newNum1 = sif1 + sif2 * 10;
            //int newNum2 = sif3 + sif4 * 10;
            //int count = 0;
            //while (num.ToString().Length == 4)
            //{
            //    count++;
            //    Console.Write("Enter a number: ");
            //    num = int.Parse(Console.ReadLine());
            //    sif1 = num % 10;
            //    sif2 = num / 10;
            //    sif3 = num / 100;
            //    sif4 = num / 1000;
            //    newNum1 = sif1 + sif2 * 10;
            //    newNum2 = sif3 + sif4 * 10;
            //}

            //תרגיל 35

            //Console.Write("Enter number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());
            //int sif1Num1;
            //int sif2Num1;
            //int sif1Num2;
            //int sif2Num2;
            //while ((num / 10 >= 1) && (num2 / 10 >= 1))
            //{
            //    sif1Num1 = num % 10;
            //    sif2Num1 = num / 10;
            //    sif1Num2 = num2 % 10;
            //    sif2Num2 = num2 / 10;
            //    if ((sif1Num1 == sif2Num2 && sif1Num2 == sif2Num1) || (sif1Num1 == sif1Num2 && sif2Num1 == sif2Num2))
            //    {
            //        Console.WriteLine("Those numbers are nice");
            //    }
            //    Console.Write("Enter number: ");
            //    num = int.Parse(Console.ReadLine());
            //    Console.Write("Enter second number: ");
            //    num2 = int.Parse(Console.ReadLine());
            //}

            //תרגיל 36

            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.Write("Enter a sif: ");
            //int sif = int.Parse(Console.ReadLine());
            //int newNum;
            //while (num % 10 != sif)
            //{
            //    newNum = (num / 10) * 10 + sif;
            //    Console.WriteLine("The new number = {0}", newNum);
            //    Console.Write("Enter a number: ");
            //    num = int.Parse(Console.ReadLine());
            //    Console.Write("Enter a sif: ");
            //    sif = int.Parse(Console.ReadLine());
            //}

            //תרגיל 37

            Console.Write("Enter a number: ");

        }
    }
}
