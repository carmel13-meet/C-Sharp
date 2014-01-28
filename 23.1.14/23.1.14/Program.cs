using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23._1._14
{
    class Program
    {
        static void Main(string[] args)
        {
            //תרגיל 18
            //int[] a = new int[int.Parse(Console.ReadLine())];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write("Enter a number: ");
            //    a[i] = int.Parse(Console.ReadLine());
            //}
            //int[] b = new int[(a.Length)+(a.Length/2)];
            //int j = 0;
            //for (int i = 0; i < a.Length; i+=2)
            //{
            //    b[j] = a[i];
            //    b[j+1] = a[i+1];
            //    if ((a[i] + a[i + 1]) % 3 == 0)
            //    {
            //        b[j+2] = a[i] + a[i + 1];
            //    }
            //    else
            //    {
            //        b[j+2] = 0;
            //    }
            //    j += 3;
            //}
            //for (int i = 0; i < b.Length; i++)
            //{
            //    Console.WriteLine(b[i]);
            //}

            //תרגיל 19
            Console.WriteLine("What's the length of your array ? ");
            int j = 0;
            int n = int.Parse(Console.ReadLine());
            int[] action = new int[n];
            int[] result = new int[n / 3];
            Random rand = new Random();
            for (int i = 0; i < n; i += 3)
            {
                action[i] = rand.Next(1, 3);
                Console.Write("Enter a number: ");
                action[i + 1] = int.Parse(Console.ReadLine());
                Console.Write("Enter a number: ");
                action[i + 2] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Action ---> ");
            for (int i = 0; i < action.Length; i++)
            {
                Console.WriteLine(action[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < action.Length; i += 3)
            {
                if (action[i] == 1)
                {
                    result[j] = action[i + 1] + action[i + 2];
                }
                else
                    result[j] = action[i + 1] - action[i + 2];
                j++;
            }

            Console.WriteLine("Result ---> ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            
        }
    }
}
