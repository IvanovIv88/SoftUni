using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n > 1 && n <= 50)    
            Console.WriteLine($"{new string('#', 4 * n + 1)}");
            int first = 1;
            int hash = 2 * n - 1;
            int space = 1;
            for (int i = 0; i < n; i++)
            {
                if (i == n / 2)
                {
                    Console.WriteLine($"{new string('.', first)}{new string('#', hash)}{new string(' ', space - n / 2 - 2)}(@){new string(' ', space - n / 2 - 2)}{new string('#', hash)}{new string('.', first)}");
                }
                else
                {
                    Console.WriteLine($"{new string('.', first)}{new string('#', hash)}{new string(' ', space)}{new string('#', hash)}{new string('.', first)}");

                }
                hash = hash - 2;
                first = first + 1;
                space = space + 2;
            }
            var hashsecond = 2 * n - 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{new string('.', first)}{new string('#', hashsecond)}{new string('.', first)}");

                hashsecond = hashsecond - 2;
                first = first + 1;
            }
        }
    }
}
