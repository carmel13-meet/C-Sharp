using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _28._10._13
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Question #1:

            //int sales = int.Parse(Console.ReadLine());
            //int tax = 0;
            //if (sales <= 1000)
            //{
            //    tax = sales / 100 * 6;
            //}
            //if (sales > 1000 && sales <= 5000)
            //{
            //    tax = sales / 100 * 10;
            //}
            //Console.WriteLine("sales = {0}", sales);
            //Console.WriteLine("tax = {0}", tax);

            ////Question #2:

            //int X = int.Parse(Console.ReadLine());
            //int Y = int.Parse(Console.ReadLine());
            //if (Y > 3)
            //{
            //    if (X > 1)
            //    {
            //        X += 2;
            //        Console.WriteLine("Math.Abs({0})", Y);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Y = {0}", Y);
            //    }
            //}
            //else
            //{
            //    X -= 5;
            //}
            //Console.WriteLine("X = {0}", X);
            //Console.WriteLine("Y= {0}", Y);

            ////Question 3:

            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //if (A > 0)
            //{
            //    A += 10;
            //    if (B > A)
            //    {
            //        B -= A;
            //    }
            //    else
            //    {
            //        A += B;
            //    }
            //}
            //else
            //{
            //    B += 3;
            //}
            //Console.WriteLine("A = {0}", A);
            //Console.WriteLine("B = {0}", B);

            ////Question 4:

            //int number1 = int.Parse(Console.ReadLine());
            //int number2 = int.Parse(Console.ReadLine());
            //int number3 = int.Parse(Console.ReadLine());
            //int number4 = Math.Max(Math.Max(number1, number2), number3);
            //Console.WriteLine("The biggest number is {0}", number4);

            //Question 5:

            //int KWh = int.Parse(Console.ReadLine());
            //double price = double.Parse(Console.ReadLine());
            //if (KWh <= 180)
            //{
            //    price = KWh * 1.45;
            //}
            //if (KWh > 180)
            //{
            //    price = KWh * 2.0;
            //    if (KWh > 1000)
            //    {
            //        price += KWh / 100 * 10;
            //    }
            //}
            //Console.WriteLine("price = {0}", price);

            //Question #6:

            //int age = int.Parse(Console.ReadLine());
            //int years = int.Parse(Console.ReadLine());
            //string criterion;
            //if (age > 55)
            //    Console.WriteLine("No job for you )-:");
            //if (age < 55 && years == 12)
            //{
            //    criterion = "Sitting academics";
            //    Console.WriteLine("age = {0}, years = {1}, suitable criterion = {2}", age, years, criterion);
            //}
            //if (age < 55 && years < 12)
            //{
            //    criterion = "Retraining";
            //    Console.WriteLine("age = {0}, years = {1}, suitable criterion = {2}", age, years, criterion);
            //}

            //Question #7:

            //Random randNumber = new Random();
            //int rib1 = randNumber.Next(1, 181);
            //int rib2 = randNumber.Next(1, 181);
            //int rib3 = randNumber.Next(1, 181);
            //if (rib1 + rib2 > rib3 || rib2 + rib3 > rib1 || rib1 + rib3 > rib2)
            //{
            //    Console.WriteLine("It's a triangle");
            //}
            //else
            //{
            //    Console.WriteLine("Goodbye");
            //}

            //Question #8:

            //Random randNumber = new Random();
            //int rib1 = randNumber.Next(1, 181);
            //int rib2 = randNumber.Next(1, 181);
            //int rib3 = randNumber.Next(1, 181);
            //if (rib1 == rib2 || rib2 == rib3 || rib1 == rib3)
            //    Console.WriteLine("Isosceles triangle");
            //if (rib1 == rib2 && rib1 == rib3)
            //    Console.WriteLine("Equilateral triangle");

            //Question #9:
            
            int number = int.Parse(Console.ReadLine());
            string number2;
			if (number < 0)
				Console.WriteLine ("Negative number");
			else 
			{
				number2 = number.ToString ();
				Console.WriteLine ("This number has {0} digits", number2.Length);

			}

            
            //Another exercise:

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //if ((b * b - (4 * a * c)) == 0)
                //Console.WriteLine("There is 1 solution = {0}", -b / 2 * a);
            //if ((b * b - (4 * a * c)) > 0)
            //{
                //double X1 = (-b + Math.Sqrt(b * b - (4 * a * c))) / 2 * a;
                //double X2 = (-b - Math.Sqrt(b * b - (4 * a * c))) / 2 * a;
                //Console.WriteLine("X1 = {0}", X1);
                //Console.WriteLine("X2 = {0}", X2);

            //}
            //if ((b * b - (4 * a * c)) < 0)
            //{
                //Console.WriteLine("There is no solution");
            //}






            
        }
    }
}
