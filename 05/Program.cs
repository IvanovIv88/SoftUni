using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int shirochina = (3 * n) + 6;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{new string(' ', n)}~ ~ ~{new string(' ', 2 * n)}");
            }
            Console.WriteLine($"{new string('=',shirochina-1)}");
            for (int i = 0; i < n - 3; i++)
            {
                if(i == (n-2) / 2)
                {
                    Console.WriteLine($"|{new string('~', n)}JAVA{new string('~', n)}|{new string(' ', n - 1)}|");
                }
                Console.WriteLine($"|{new string('~',((2 * n)+4))}|{new string(' ', n-1)}|");
            }
            Console.WriteLine($"{new string('=', shirochina-1)}");
            var dotleft = 0;
            var dotright = n - 1;
            var klom = (2 * n) + 4;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{new string(' ', dotleft)}\\{new string('@', klom)}/{new string(' ', dotright)}");
                dotleft++;
                dotright++;
                klom = klom - 2;
            }
            Console.WriteLine($"{new string('=', shirochina - n)}");
        }
    }
}
