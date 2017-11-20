using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaces
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = Double.Parse(Console.ReadLine());
            double y1 = Double.Parse(Console.ReadLine());
            double x2 = Double.Parse(Console.ReadLine());
            double y2 = Double.Parse(Console.ReadLine());

            double a = Math.Max(x1, x2) - Math.Min(x1, x2);
            double b = Math.Max(y1, y2) - Math.Min(y1, y2);
           
            Console.WriteLine($"Area= {a*b}");
            Console.WriteLine($"Perimeter= {(a + b) * 2}");
        }   
    }      
}           
