using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dot = 1;
            var dotmid = 1;
            var space = n - 2;
            var spacen = n - 5;
            if (n % 2 == 0 && n > 7 && n <=50)
            {
                Console.WriteLine($"@{new string(' ', space)}@{new string(' ', space)}@");
                Console.WriteLine($"**{new string(' ', space - 1)}*{new string(' ', space - 1)}**");
                for (int i = 0; i < n / 2 - 1; i++)
                {

                    if (spacen < 0)
                    {
                        Console.WriteLine($"*{new string('.', dot)}*{new string('.', dotmid)}*{new string('.', dot)}*");

                    }
                    else
                    {
                        Console.WriteLine($"*{new string('.', dot)}*{new string(' ', spacen)}*{new string('.', dotmid)}*{new string(' ', spacen)}*{new string('.', dot)}*");
                        dot = dot + 1;
                        spacen = spacen - 2;
                        dotmid = dotmid + 2;
                    }

                }
                Console.WriteLine($"*{new string('.', dot + 1)}{new string('*', dotmid / 2)}.{new string('*', dotmid / 2)}{new string('.', dot + 1)}*");
                Console.WriteLine($"*{new string('*', (2 * n) - 2)}");
                Console.WriteLine($"*{new string('*', (2 * n) - 2)}");
            }

        }
    }
}
