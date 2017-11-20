using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 2 && n <= 1000)
            {
                var vruh = ((2 * n) / 3) - 1;

                Console.WriteLine($"/{new string('^', vruh)}\\{new string('_', vruh)}/{new string('^', vruh)}\\");

            }

        }
    }
}
