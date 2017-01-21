using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var blanks = n;

            for (int rows = 1; rows <= n; rows++)
            {
                blanks--;
                //Console.Write(new string(' ', blanks));
                for (int i = 0; i < blanks; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 1; i <= rows; i++)
                {
                    Console.Write("* " );
                }
                Console.WriteLine();
               
            }


            for (int rows = 1; rows <= n -1; rows++)
            {
                blanks++;
                //Console.Write(new string(' ', blanks));
                for (int i = 0; i < blanks; i++)
                {
                    Console.Write(" ");
                }
                for (int i = rows; i < n; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }

        }
    }
}
