using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dots = n + 1;
            int underline = 2 * n + 1;

            Console.WriteLine($"{new string('.', dots)}{new string('_', underline)}{new string('.', dots)}");

            dots--;
            underline -= 2;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{new string('.', dots)}//{new string('_', underline)}\\\\{new string('.', dots)}");
                dots--;
                underline += 2;
            }
            Console.WriteLine($"//{new string('_', (underline - 5) / 2)}STOP!{new string('_', (underline - 5) / 2)}\\\\");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{new string('.', i)}\\\\{new string('_', underline)}//{new string('.', i)}");
                underline -= 2;
            }
        }
    }
}
