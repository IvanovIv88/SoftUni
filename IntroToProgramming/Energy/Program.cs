using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());

            for (int i = 0; i < days; i++)
            {
                double hours = double.Parse(Console.ReadLine());
                if (i % 2 == 0)

            }
            double odddaysandhours = dancers * 30;
            double evendaysandhours = dancers * 68;
            double odddaysandhours2 = dancers * 49;
            double evendaysandhours2 = dancers * 65;
            double totalenergy = 100 * days * dancers;
            double lefteneryforday = totalenergy - (odddaysandhours + evendaysandhours + odddaysandhours2 + evendaysandhours2);
            double lefteneryfordancer = lefteneryforday / dancers / days;
            if (lefteneryfordancer <= 50)
                Console.WriteLine($"They feel good! Energy left: {lefteneryfordancer:f2}");
            else
                Console.WriteLine($"They are wasted!Energy left: { lefteneryfordancer:f2}");

        }
    }
}
