using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double kolichestvo = double.Parse(Console.ReadLine());
            double kasetki = double.Parse(Console.ReadLine());
            double burkani = double.Parse(Console.ReadLine());

            double totallutenica = kolichestvo / 5;
            double totalburkani = totallutenica / 0.535;
            double totalkasetki = totalburkani / burkani;
            Console.WriteLine($"Total lutenica: {Math.Floor(totallutenica)} kilograms.");

            if (totalkasetki >= kasetki)
            {
                double ostavashtikasetki = Math.Floor(totalkasetki - kasetki);
                double ostavashtiburkani = Math.Floor((totalburkani - (kasetki * burkani)));
                Console.WriteLine($"{ostavashtikasetki} boxes left.");
                Console.WriteLine($"{ostavashtiburkani} jars left.");
            }
            else
            {
                double ostavashtikasetki = Math.Floor(kasetki - totalkasetki);
                double ostavashtiburkani = Math.Floor(((kasetki * burkani) - totalburkani));
                Console.WriteLine($"{ostavashtikasetki} more boxes needed.");
                Console.WriteLine($"{ostavashtiburkani} more jars needed.");
            }
        }
    }
}
