using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11._11._13_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //int hours = 0;
            //int minutes = 0;
            //int seconds = 0;
            //for (int time = 0; time >= 0; time++)
            //{
            //    Console.BackgroundColor = ConsoleColor.Black;
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.Clear();
            //    Console.SetCursorPosition(15, 10);
            //    seconds++;
            //    if (seconds == 60)
            //    {
            //        seconds = 0;
            //        minutes++;
            //        Console.BackgroundColor = ConsoleColor.Yellow;
            //        Console.ForegroundColor = ConsoleColor.Black;
                    

            //        if (minutes == 60)
            //        {
            //            minutes = 0;
            //            hours++;
            //            if (hours == 24)
            //                break;
                       
            //        }
            //    }
            //    Console.WriteLine("{0}:{1}:{2}", hours, minutes, seconds);
            //    for (long time2 = 0; time2 < 100000000; time2++) ;
            //    Console.Clear();
            //}

            for (int h = 0; h < 24; h++)
            {
                int a = 0;

                for (int m = 0; m <= 59; m++)
                {
                    for (int s = 0; s <= 59; s++)
                    {
                        Console.SetCursorPosition(10, 15);
                        Console.Write("{0}:{1}:{2}", h, m, s);
                        for (int time = 0; time < 100000000; time++) ;
                        if (a % 2 == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        a++;
                        Console.Clear();
                        
                           
                    }
                }
            }

                
                
            
        }
    }
}
