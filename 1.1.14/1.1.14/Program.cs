using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unit4.TurtleLib;

namespace _1._1._14
{
    class Program
    {
        public static void Circles()
        {
            Turtle arielT = new Turtle();
            Turtle arielT2 = new Turtle();
            Turtle arielT3 = new Turtle();
            Turtle arielT4 = new Turtle();
            double x = 1;
            double y = 1;
            int i = 1;
            while (i <= 50)
            {
                arielT.TailDown();
                arielT2.TailDown();
                arielT3.TailDown();
                arielT4.TailDown();
                arielT.MoveBackward(x);
                arielT2.MoveForward(x);
                arielT3.MoveBackward(x);
                x = x + 0.5;
                arielT.TurnLeft(y);
                arielT2.TurnRight(y);
                arielT3.TurnRight(y);
                arielT4.TurnLeft(y);
                y = y + 0.5;
                arielT.SetDelay(1);
                arielT2.SetDelay(1);
                arielT3.SetDelay(1);
                arielT4.SetDelay(1);
                i++;

            }
        }
        public static void CoolSquare()
        {
            Turtle arielT = new Turtle();
            Turtle arielT2 = new Turtle();
            Turtle arielT3 = new Turtle();
            Turtle arielT4 = new Turtle();
            double alachson = Math.Sqrt(2 * Math.Pow(100, 2));
            arielT.TailDown();
            arielT.TurnRight(45);
            arielT.MoveForward(Math.Sqrt(2 * Math.Pow(100, 2)));
            arielT.TurnLeft(135);
            arielT.MoveForward(100);
            arielT.TurnLeft(135);
            arielT.MoveForward(Math.Sqrt(2 * Math.Pow(100, 2)));
            arielT.TurnRight(135);
            arielT.MoveForward(100);
            arielT.TurnRight(90);
            arielT.MoveForward(100);
            arielT.TurnRight(45);
            arielT.MoveForward(0.5*alachson);
            arielT.TurnRight(90);
            arielT.MoveForward(0.5*alachson);
            arielT.TurnRight(45);
            arielT.MoveForward(100);
        }
        public static void Secret()
        {
            Turtle arielT = new Turtle();
            Turtle arielT2 = new Turtle();
            Turtle arielT3 = new Turtle();
            Turtle arielT4 = new Turtle();
            Turtle arielT5 = new Turtle();
            Turtle arielT6 = new Turtle();
            Turtle arielT7 = new Turtle();
            Turtle arielT8 = new Turtle();
            int x = 1;
            while (1 > 0)
            {
                arielT.TailDown();
                arielT2.TailDown();
                arielT3.TailDown();
                arielT4.TailDown();
                arielT5.TailDown();
                arielT6.TailDown();
                arielT7.TailDown();
                arielT8.TailDown();
                arielT.SetVisible(false);
                arielT2.SetVisible(false);
                arielT3.SetVisible(false);
                arielT4.SetVisible(false);
                arielT5.SetVisible(false);
                arielT6.SetVisible(false);
                arielT7.SetVisible(false);
                arielT8.SetVisible(false);
                arielT.SetDelay(1);
                arielT2.SetDelay(1);
                arielT3.SetDelay(1);
                arielT4.SetDelay(1);
                arielT5.SetDelay(1);
                arielT6.SetDelay(1);
                arielT7.SetDelay(1);
                arielT8.SetDelay(1);
                arielT.TurnLeft(45);
                arielT2.TurnRight(45);
                arielT3.TurnRight(45);
                arielT4.TurnLeft(45);
                arielT5.TurnLeft(90);
                arielT6.TurnRight(90);
                arielT7.TurnRight(90);
                arielT8.TurnLeft(90);
                arielT.MoveBackward(x);
                arielT2.MoveBackward(x);
                arielT3.MoveForward(x);
                arielT4.MoveForward(x);
                x++;
            }

        }
        static void Main(string[] args)
        {
            Turtle t = new Turtle();
            t.SetDelay(1);
            t.TailDown();
            
            ConsoleKeyInfo move;
            move = Console.ReadKey();
            while (move.Key != ConsoleKey.E)
            {
                if (move.Key == ConsoleKey.UpArrow)
                {
                    t.MoveForward(1);
                    t.TailUp();
                }
                if (move.Key == ConsoleKey.DownArrow)
                {
                    t.MoveBackward(1);
                    t.TailUp();
                }
                if (move.Key == ConsoleKey.RightArrow)
                    t.TurnRight(45);
                if (move.Key == ConsoleKey.LeftArrow)
                    t.TurnLeft(45);

            }

        
        }
    }
}
