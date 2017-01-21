using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //    var n = int.Parse(Console.ReadLine());

            //    var blanks = n;
            //    var stars = 0;

            //    for (int rows = 1; rows <= n; rows++)
            //    {
            //        blanks--;
            //        stars++;
            //        //Console.Write(new string(' ', blanks));
            //        if (rows == 1)
            //        {

            //            Console.Write(new string(' ', blanks+1));
            //            Console.WriteLine(" | ");
            //        }

            //        for (int i = 0; i < blanks; i++)
            //        {
            //            Console.Write(" ");
            //        }

            //        for (int i = 0; i < stars; i++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.Write(" | ");

            //        for (int i = 0; i < stars; i++)
            //        {
            //            Console.Write("*");
            //        }

            //        for (int i = 0; i < blanks; i++)
            //        {
            //            Console.Write(" ");
            //        }

            //        Console.WriteLine();
            //    }

            var n = int.Parse(Console.ReadLine());

            Console.Write(new string (' ', n));
            Console.WriteLine(" | ");

            var blanks = n - 1;
            var stars = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', blanks));
                Console.Write(new string('*', stars));
                Console.Write(" | ");
                Console.Write(new string('*', stars));
                Console.Write(new string(' ', blanks));
                Console.WriteLine();
                blanks--;
                stars++;
            }

        }
    }
}
