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
            
            int hours = 0;
            int minutes = 0;
            int seconds = 0;
            for (int time = 0; time>=0; time++)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.SetCursorPosition(15, 10);
                seconds++;
                if (seconds == 60)
                {
                    seconds = 0;
                    minutes++;

                    if (minutes == 60)
                    {
                        minutes = 0;
                        hours++;
                        if (hours == 24)
                            break;
                    }
                }
                Console.WriteLine("{0}:{1}:{2}", hours, minutes, seconds);
                for (long time2 = 0; time2 < 100000000; time2++) ;
                Console.Clear();
            }

                
                
            
        }
    }
}
