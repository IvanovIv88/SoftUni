using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 != 0)
            {
                var dots = (3 * n - 3) / 2;
                var ex = n - 1;

                Console.WriteLine($"{new string('.', dots)}.x.{new string('.', dots)}");
                Console.WriteLine($"{new string('.', dots)}/x\\{new string('.', dots)}");
                Console.WriteLine($"{new string('.', dots)}x|x{new string('.', dots)}");
                for (int i = 0; i < n / 2 + 1; i++)
                {
                    Console.WriteLine($"{new string('.', dots - (n - 1))}{new string('x', ex)}x|x{new string('x', ex)}{ new string('.', dots - (n - 1))}");
                    dots = dots - 1;
                    ex = ex + 1;
                }
                var exunder = (3 * n - 3) / 2;
                var dotsunder = 1;
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine($"{new string('.', dotsunder)}{new string('x', exunder - 1)}x|x{new string('x', exunder - 1)}{ new string('.', dotsunder)}");
                    dotsunder = dotsunder + 1;
                    exunder = exunder - 1;
                }
                var newdots = (3 * n - 3) / 2;
                Console.WriteLine($"{new string('.', newdots)}/x\\{new string('.', newdots)}");
                Console.WriteLine($"{new string('.', newdots)}\\x/{new string('.', newdots)}");
                var newdots2 = (3 * n - 3) / 2;
                var newex2 = n - 1;
                for (int i = 0; i < n / 2 + 1; i++)
                {
                    Console.WriteLine($"{new string('.', newdots2 - (n - 1))}{new string('x', newex2)}x|x{new string('x', newex2)}{ new string('.', newdots2 - (n - 1))}");
                    newdots2 = newdots2 - 1;
                    newex2 = newex2 + 1;
                }
                var exunder2 = (3 * n - 3) / 2;
                var dotsunder2 = 1;
                for (int i = 0; i < n / 2; i++)
                {
                    Console.WriteLine($"{new string('.', dotsunder2)}{new string('x', exunder2 - 1)}x|x{new string('x', exunder2 - 1)}{ new string('.', dotsunder2)}");
                    dotsunder2 = dotsunder2 + 1;
                    exunder2 = exunder2 - 1;
                }
                Console.WriteLine($"{new string('.', newdots)}x|x{new string('.', newdots)}");
                Console.WriteLine($"{new string('.', newdots)}\\x/{new string('.', newdots)}");
                Console.WriteLine($"{new string('.', newdots)}.x.{new string('.', newdots)}");
            }
        }
    }
}
