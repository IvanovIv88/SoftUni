using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            double teglo = double.Parse(Console.ReadLine());
            string usluga = Console.ReadLine().ToLower();
            double razstoqnie = double.Parse(Console.ReadLine());


            if (usluga == "standard")
            {
                if (teglo < 1)
                {
                    var cena = razstoqnie * 0.03;
                    Console.WriteLine($"The delivery of your shipment with weight of {teglo:f3} kg. would cost {cena:f2} lv.");
                }
                if (teglo >= 1 && teglo <= 10)
                {
                    var cena = razstoqnie * 0.05;
                    Console.WriteLine($"The delivery of your shipment with weight of {teglo:f3} kg. would cost {cena:f2} lv.");
                }
                if (teglo > 10 && teglo <= 40)
                {
                    var cena = razstoqnie * 0.10;
                    Console.WriteLine($"The delivery of your shipment with weight of {teglo:f3} kg. would cost {cena:f2} lv.");
                }
                if (teglo > 40 && teglo <= 90)
                {
                    var cena = razstoqnie * 0.15;
                    Console.WriteLine($"The delivery of your shipment with weight of {teglo:f3} kg. would cost {cena:f2} lv.");
                }
                if (teglo > 90 && teglo <= 150)
                {
                    var cena = razstoqnie * 0.20;
                    Console.WriteLine($"The delivery of your shipment with weight of {teglo:f3} kg. would cost {cena:f2} lv.");

                }
            }
            if (usluga == "express")
            {
                if (teglo < 1)
                {
                    var cena = razstoqnie * 0.03;
                    var nadcenka = 0.03 * 0.80;
                    var kilograminadcenka = nadcenka * teglo;
                    var cenanadcenka = razstoqnie * kilograminadcenka;
                    Console.WriteLine($"The delivery of your shipment with weight of {teglo:f3} kg. would cost {(cena + cenanadcenka):f2} lv.");
                }
                if (teglo >= 1 && teglo <= 10)
                {
                    var cena = razstoqnie * 0.05;
                    var nadcenka = 0.05 * 0.40;
                    var kilograminadcenka = nadcenka * teglo;
                    var cenanadcenka = razstoqnie * kilograminadcenka;
                    Console.WriteLine($"The delivery of your shipment with weight of {teglo:f3} kg. would cost {(cena + cenanadcenka):f2} lv.");
                }
                if (teglo > 10 && teglo <= 40)
                {
                    var cena = razstoqnie * 0.10;
                    var nadcenka = 0.10 * 0.05;
                    var kilograminadcenka = nadcenka * teglo;
                    var cenanadcenka = razstoqnie * kilograminadcenka;
                    Console.WriteLine($"The delivery of your shipment with weight of {teglo:f3} kg. would cost {(cena + cenanadcenka):f2} lv.");
                }
                if (teglo > 40 && teglo <= 90)
                {
                    var cena = razstoqnie * 0.15;
                    var nadcenka = 0.15 * 0.02;
                    var kilograminadcenka = nadcenka * teglo;
                    var cenanadcenka = razstoqnie * kilograminadcenka;
                    Console.WriteLine($"The delivery of your shipment with weight of {teglo:f3} kg. would cost {(cena + cenanadcenka):f2} lv.");
                }
                if (teglo > 90 && teglo <= 150)
                {
                    var cena = razstoqnie * 0.20;
                    var nadcenka = 0.20 * 0.01;
                    var kilograminadcenka = nadcenka * teglo;
                    var cenanadcenka = razstoqnie * kilograminadcenka;
                    Console.WriteLine($"The delivery of your shipment with weight of {teglo:f3} kg. would cost {(cena + cenanadcenka):f2} lv.");

                }
            }
        }
    }
}

