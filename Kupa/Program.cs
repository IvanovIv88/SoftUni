using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kupa
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dots = n;
            var hash = n * 3;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine($"{new string('.', dots)}{new string('#', hash)}{new string('.', dots)}");
                dots = dots + 1;
                hash = hash - 2;
            }
            hash = hash - 2;
            for (int i = 0; i < n/2 + 1; i++)
            {
                Console.WriteLine($"{new string('.', dots)}#{new string('.', hash)}#{new string('.', dots)}");
                dots = dots + 1;
                hash = hash - 2;
            }
            dots = dots - 1;
            hash = hash + 4;
            Console.WriteLine($"{new string('.', dots)}{new string('#', hash)}{new string('.', dots)}");
            dots = dots - 2;
            hash = hash + 4;
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine($"{new string('.', dots)}{new string('#', hash)}{new string('.', dots)}");
            }
            if(n == 6)
            Console.WriteLine($"{new string('.', dots)}D^A^N^C^E^{new string('.', dots)}");
            else if (n > 6 && n % 2 == 0)
             Console.WriteLine($"{new string('.', dots+hash/2-5)}D^A^N^C^E^{new string('.', dots + hash / 2 - 5)}");
            else if(n > 6 && n % 2 != 0)
                Console.WriteLine($"{new string('.', dots + hash / 2 - 4)}D^A^N^C^E^{new string('.', dots + hash / 2 - 5)}");

            for (int i = 0; i < n / 2 +1; i++)
            {
                Console.WriteLine($"{new string('.', dots)}{new string('#', hash)}{new string('.', dots)}");
            }
        }
    }
}
