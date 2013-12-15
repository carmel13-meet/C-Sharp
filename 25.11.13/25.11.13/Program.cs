using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _25._11._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            //Console.Write("Enter number: ");
            //int count = 0;
            //int i = 2;
            //int number = int.Parse(Console.ReadLine());
            //double maxNumber = Math.Sqrt(number);
            //while (i < maxNumber)
            //{
            //    if (number % i == 0)
            //        count++;
            //    i++;
            //}
            //if (count == 0)
            //    Console.WriteLine("This is mispar rishoni");
            //if (count != 0)
            //    Console.WriteLine("This is not mispar rishoni");

            //שיעורי בית

            //תרגיל ראשון
            //int equals_zero=0;
            //int bigger_than_zero=0;
            //int smaller_than_zero = 0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.Write("Enter number: ");
            //    int number = int.Parse(Console.ReadLine());
            //    if (number == 0)
            //        equals_zero += 1;
            //    if (number > 0)
            //        bigger_than_zero += 1;
            //    if (number < 0)
            //        smaller_than_zero += 1;
                
            //}
            //Console.WriteLine("{0} are equal to zero", equals_zero);
            //Console.WriteLine("{0} are bigger than zero", bigger_than_zero);
            //Console.WriteLine("{0} are smaller than zero", smaller_than_zero);

            //תרגיל שני

            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Random randNumber = new Random();
            int number2 = randNumber.Next(1, 11);
            while (number != number2)
            {
                Console.Write("Almost there , wanna guess again (click Y/n) ? ");
                string answer = Console.ReadLine();
                if (answer == "Y")
                {
                    Console.Write("Enter the new number: ");
                    number = int.Parse(Console.ReadLine());
                }
                if (answer == "n")
                {
                    Console.WriteLine("The number is {0}", number2);
                    break;
                }
                if (number == number2)
                {
                    Console.WriteLine("Congratulations !");
                    break;
                }
            }
        }
    }
}
