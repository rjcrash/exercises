using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            //var n = int.Parse(Console.ReadLine());

            //Console.Write("+");
            //for (int i = 0; i < n - 2; i++)
            //    Console.Write(" -");
            //Console.WriteLine(" +");

            //for (int i = 0; i < n - 2; i++)
            //{
            //    Console.Write("|");
            //    for (int j = 0; j < n - 2; j++)
            //        Console.Write(" -");
            //    Console.WriteLine(" |");
            //}

            //Console.Write("+");
            //for (int i = 0; i < n - 2; i++)
            //    Console.Write(" -");
            //Console.WriteLine(" +");

            //var n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    if (i == 0 || i == n - 1)
            //    {
            //        Console.Write("+ ");
            //    }
            //    else if (i > 0 || i < n - 1)
            //    {
            //        Console.Write("| ");
            //    }
            //    for (int j = 0; j < n-2; j++)
            //    {
            //        Console.Write("- ");
            //    }
            //    if (i == 0 || i == n - 1)
            //    {
            //        Console.Write("+ ");
            //    }
            //    else if (i > 0 || i < n - 1)
            //    {
            //        Console.Write("| ");
            //    }
            //    Console.WriteLine();

            //}

            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                if (row == 1 || row == n)
                {
                    for (int col = 1; col <= n; col++)
                    {
                        if (col == 1 || col == n)
                        {
                            Console.Write("+ ");
                        }
                        else
                        {
                            Console.Write("- ");
                        }
                    }
                    
                }
               
                else
                {
                    for (int col = 1; col <= n; col++)
                    {
                        if (col == 1 || col == n)
                        {
                            Console.Write("| ");
                        }
                        else
                        {
                            Console.Write("- ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
