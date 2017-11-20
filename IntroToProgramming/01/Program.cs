using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double duljina = double.Parse(Console.ReadLine());
            double shirochina = double.Parse(Console.ReadLine());
            double visochina = double.Parse(Console.ReadLine());
            double cena = double.Parse(Console.ReadLine());
            double teglo = double.Parse(Console.ReadLine());

            double totalduljina = (2 * duljina) + (2 * shirochina);
            double totalcena = totalduljina * cena;
            double plosht = totalduljina * visochina;
            double totalteglo = plosht * teglo;

            Console.WriteLine(totalduljina);
            Console.WriteLine($"{totalcena:f2}");
            Console.WriteLine($"{totalteglo:f3}");
        }
    }
}
