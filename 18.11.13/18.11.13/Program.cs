using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18._11._13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Targil 7
            //for (int i = 1; i <= 50; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine();

            //Targil 8
            //for (char ariel = 'a'; ariel <= 'z'; ariel++)
            //{
            //    Console.WriteLine(ariel);
            //}

            //Targil 9
            int count = 0;
            char carmel = 'a';
            for (char ariel = 'a'; ariel <= 'z'; ariel++)
            {
                count++;
                if (count % 2 != 0)
                {
                    carmel = ariel;
                    Console.WriteLine(carmel);
                }
            }

            //Targil 11
            //for (int i=2; i<=20; i+=2)
            //    Console.Write(i + " ");

            //Console.WriteLine();
            //Console.WriteLine();

            //for (int i=3; i<=20; i+=3)
            //    Console.Write(i + " ");

            //Console.WriteLine();
            //Console.WriteLine();

            //for (int i=4; i<=20; i+=4)
            //    Console.Write(i + " ");

            //Console.WriteLine();
            //Console.WriteLine();

            //Targil 19

            //int temperature=0;
            //for (int day = 1; day <= 30; day++)
            //{

            //}


        }
    }
}
