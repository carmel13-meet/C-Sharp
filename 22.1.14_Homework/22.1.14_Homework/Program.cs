using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22._1._14_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int turn = 0;
            int money = 100;
            Random rand = new Random();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            while (money > 0 && money < 10000)
            {
                turn++;
                int cube = rand.Next(1, 7);
                Console.Write("Enter your bet: ");
                int bet = int.Parse(Console.ReadLine());
                if (cube == bet)
                {
                    money = money * 10;
                }
                else
                {
                    money = money / 10;
                }
                Console.WriteLine("The cube was {0}", cube);
                Console.WriteLine("Your money stands on {0} shekels", money);
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            if (money <= 0)
            {

                Console.WriteLine("Goddamn! You've lost after {0} turns", turn);
            }
            if (money >= 10000)
            {
                Console.WriteLine("Congratulations! You've won after {0} turns", turn);
            }
        }
    }
}
