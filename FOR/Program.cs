using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double evenmax = double.MinValue;
            double evenmin = double.MaxValue;
            double oddmax = double.MinValue;
            double oddmin = double.MaxValue;
            double oddsum = 0.00;
            double evensum = 0.00;

            for (int i = 0; i <= n-1; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                    oddsum = oddsum + num;
                
                    if (num > oddmax)
                        oddmax = num;
                    if (num < oddmin)
                        oddmin = num;
                
                else if (i % 2 != 0)
                evensum = evensum + num;
                
                    if (num > evenmax)
                        evenmax = num;
                    if (num < evenmin)
                        evenmin = num;
                
            }
            Console.WriteLine($"OddSum="+oddsum);
            Console.WriteLine($"OddMin="+oddmin);
            Console.WriteLine($"OddMax="+oddmax);
            Console.WriteLine($"EvenSum="+evensum);
            Console.WriteLine($"EvenMin="+evenmin);
            Console.WriteLine($"EvenMax="+evenmax);
        }
    }
}