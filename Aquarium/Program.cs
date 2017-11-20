using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            double loze = double.Parse(Console.ReadLine());
            double grozde = double.Parse(Console.ReadLine());
            double litri = double.Parse(Console.ReadLine());
            double rabotnici = double.Parse(Console.ReadLine());

            double obshtogrozde = loze * grozde;
            double vinoto = (0.4 * obshtogrozde) / 2.5;
            double ok = (vinoto - litri) / rabotnici;
            double ok2 = vinoto - litri;

            if (ok2 < 0)
                Math.Ceiling(ok2);
            else
                Math.Floor(ok2);
                    

            if (vinoto >= litri)
            {
                Console.WriteLine("Good harvest this year! Total wine: " + Math.Floor(vinoto) + " liters.");
                Console.WriteLine(Math.Ceiling(ok2) + " liters left -> " + Math.Ceiling(ok)+ " liters per person.");
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More "+Math.Abs((Math.Round(ok2,0)))+ " liters wine needed.");
            }
        }
    }
}
