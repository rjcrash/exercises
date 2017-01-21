using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var stars = 1;
            if (n % 2 == 0)
            {
                stars = 2;
            }
            var leftRightBlanks = (n - stars) / 2;

            for (int i = 0; i < (n+1)/2; i++)
            {
                Console.Write(new string('-', leftRightBlanks));
                Console.Write(new string('*', stars));
                Console.Write(new string('-', leftRightBlanks));

                leftRightBlanks--;
                stars = stars + 2;
                Console.WriteLine();
            }
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}{0}", '|', new string('*',n-2));
            }
        }
    }
}
