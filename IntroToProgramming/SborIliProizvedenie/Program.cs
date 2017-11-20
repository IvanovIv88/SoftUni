using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SborIliProizvedenie
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool no = false;
            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30 ; c++)
                    {
                        if ((a + b + c) == n && a < b && b < c)
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {n}");
                            no = true;
                        }

                        else if ((a * b * c) == n && a > b && b > c)
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {n}");
                            no = true;
                        }
                    }
                }
            }
            if (no == true)
            {

            }
            else
            {
                Console.WriteLine($"No!");
            }
       
        }
    }
}
