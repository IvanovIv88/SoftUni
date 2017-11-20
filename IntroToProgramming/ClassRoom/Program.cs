using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double O = double.Parse(Console.ReadLine());

            double areawithoutpeika = N * N;
            double areaplochka = W * L;
            double areapeika = M * O;

            double area = areawithoutpeika - areapeika;
            double plochki = area / areaplochka;

            double vremeplochki = plochki * 0.2;

            Console.WriteLine(plochki);
            Console.WriteLine(vremeplochki);
        }
    }
}
