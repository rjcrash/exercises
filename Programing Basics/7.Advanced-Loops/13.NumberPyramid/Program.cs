﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write(num + " ");
                    num++;
                    if (num > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();

                if (num > n)
                {
                    break;
                }
            }
        }
    }
}
