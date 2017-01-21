using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //var n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{


            //    for (int j = 0; j < n * 2; j++)
            //    {
            //        if (i == 0 || i == n - 1)
            //        {
            //            Console.Write("*");
            //        }
            //        if (i == j)
            //        {
            //            Console.Write("*");
            //        }


            //    }
            //    for (int j = 0; j < (n * 2)-2; j++)
            //    {
            //        if (i == 0 || i == n - 1)
            //        {

            //        }

            //        else
            //        {
            //            Console.Write("/");
            //        }

            //    }
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == 1)
            //        {
            //            Console.Write("|");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }

            //    }
            //    for (int j = 0; j < n * 2; j++)
            //    {

            //        if (i == 0 || i == n - 1)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }

            //    }

            //    Console.WriteLine();

            //}

            var n = int.Parse(Console.ReadLine());

            Console.Write(new string('*', n*2));
            Console.Write(new string(' ', n));
            Console.Write(new string('*', n * 2));
            Console.WriteLine();
            for (int i = 1; i <= n-2; i++)
            {

                Console.Write("*");
                Console.Write(new string('/', (n*2)-2));
                Console.Write("*");

                if (i == (n-1)/2)
                {
                    Console.Write(new string('|',n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }

                Console.Write("*");
                Console.Write(new string('/', (n * 2) - 2));
                Console.Write("*");
                Console.WriteLine();
            }

            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.Write(new string('*', n * 2));
            Console.WriteLine();
        }
    }
}
