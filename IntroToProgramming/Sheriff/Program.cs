using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheriff
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var controlnum = 0;
            var a1 = 0;
            var b1 = 0;
            var c1 = 0;
            var d1 = 0;
            for (int a = 1; a <= 9; a++)
            {
                for (int b  = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if ((a * b) + (c * d) == n && (a < b) && (c > d))
                            {
                                controlnum = controlnum + 1;
                                Console.Write($"{a}{b}{c}{d} ");
                                if (controlnum == 4)
                                {
                                    a1 = a;
                                    b1 = b;
                                    c1 = c;
                                    d1 = d;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            if (controlnum > 4)
            {
                Console.WriteLine($"Password: {a1}{b1}{c1}{d1}");
            }
            else
            {
                Console.WriteLine($"No!");
            }
        }
    }
}
