using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;

            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Entered even number: {0}", n);
                        break;
                    }
                    
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid number");
                }
              
               

            }
           
        }
    }
}
