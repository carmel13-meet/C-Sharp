using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18._12._13
{
    class Program
    {
        static void Main(string[] args)
        {
            //#24 

            int countTom = 0;
            int countJerry = 0;
            int tom = 10;
            int jerry = 40;
            Random randNum = new Random();
            int place = 0; 
            while ((jerry != tom) && (jerry >= 1 && jerry <= 50) && (tom >= 1 && tom <= 50))
            {
                place = randNum.Next(-5, 6);
                tom += place;
                countTom++;
                jerry += place;
                countJerry++;  
            }
            if (jerry == tom)
            {
                if (countJerry > countTom)
                    Console.WriteLine("Jerry has won the game");
                if (countTom > countJerry)
                    Console.WriteLine("Tom has won the game");
            }
            else
            {
                if (jerry < 1 || jerry > 50)
                    Console.WriteLine("Tom has won the game");
                if (tom < 1 || tom > 50)
                    Console.WriteLine("Jerry has won the game");
            }
        }
    }
}
