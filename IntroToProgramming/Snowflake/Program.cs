using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dots = n;
            var firstdots = 1;
            Console.WriteLine($"*{new string('.', dots)}*{new string('.', dots)}*");
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine($"{new string('.', firstdots)}*{new string('.', dots-1)}*{new string('.', dots-1)}*{new string('.', firstdots)}");
                firstdots = firstdots + 1;
                dots = dots - 1;
            }
            Console.WriteLine($"{new string('.', n-1)}{new string('*', 5)}{new string('.', n-1)}");
            Console.WriteLine($"{new string('*', (n * 2 - 2 ) + 5)}");
            Console.WriteLine($"{new string('.', n - 1)}{new string('*', 5)}{new string('.', n - 1)}");
            {
                for (int i = 0; i < n - 2; i++)
                {
                    Console.WriteLine($"{new string('.', firstdots-1)}*{new string('.', dots)}*{new string('.', dots )}*{new string('.', firstdots-1)}");
                    firstdots = firstdots - 1;
                    dots = dots + 1;
                }
                Console.WriteLine($"*{new string('.', n)}*{new string('.', n)}*");
            }
        }
    }
}
