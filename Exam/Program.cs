using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var under = n - 1;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{new string(' ', under)}*");
                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write($"-*");
                }
                under--;
                Console.WriteLine();
            }

            under++;
            for (int i = n-1; i >= 1; i--)
            {
                under++;

                Console.Write($"{new string(' ', under)}*");
                for (int j = 0; j < i - 1; j++)
                {
                    Console.Write($"_*");
                }
                Console.WriteLine();
            }
        }
    }
}
