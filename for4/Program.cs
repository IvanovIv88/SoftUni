using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for4
{
    class Program
    {
        static void Main(string[] args)
        {
            double examhours = double.Parse(Console.ReadLine());
            double examminutes = double.Parse(Console.ReadLine());
            double arrivehours = double.Parse(Console.ReadLine());
            double arriveminuts = double.Parse(Console.ReadLine());
            if (arrivehours == 00 && arrivehours == 0)
            {
                arrivehours = 24;
            }
            if (examhours == 0 && examhours == 0)
            {
                examhours = 24;
            }
            double totalexamminuts = (examhours * 60) + examminutes;
            double totalarriveminuts = (arrivehours * 60) + arriveminuts;
            double latehours = 0;
            double lateminutes = 0;
            double ontime = 0;
            double earlyhours = 0;
            double earlyminutes = 0;

            if (totalarriveminuts == totalexamminuts)
            {
                Console.WriteLine("On time");
                return;
            }

            if (totalarriveminuts > totalexamminuts)
            {
                lateminutes = totalarriveminuts - totalexamminuts;
                if (lateminutes >= 60)
                {
                    latehours = Math.Floor(lateminutes / 60);
                    lateminutes = Math.Round(Math.Abs((((lateminutes / 60) - latehours) * 60)), 0);
                    if (lateminutes < 10)
                    {
                        Console.WriteLine($"Late {latehours}:0{lateminutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"Late {latehours}:{lateminutes} hours after the start");
                    }

                }
                else
                {
                    if (lateminutes < 10)
                    {
                        Console.WriteLine($"Late 0{lateminutes} minutes after the start");
                    }
                    else
                    {
                        Console.WriteLine($"Late {lateminutes} minutes after the start");

                    }
                }
            }
            else if (totalexamminuts - 30 <= totalarriveminuts)
            {
                ontime = totalexamminuts - totalarriveminuts;
                Console.WriteLine($"On time {ontime} minutes before the start");
            }
            if (totalexamminuts - 30 > totalarriveminuts)
            {
                earlyminutes = totalexamminuts - totalarriveminuts;
                if (earlyminutes >= 60)
                {
                    earlyhours = Math.Floor(earlyminutes / 60);
                    earlyminutes = Math.Round(Math.Abs((((earlyminutes / 60) - earlyhours) * 60)), 0);
                    if (earlyminutes < 10)
                    {
                        Console.WriteLine($"Early {earlyhours}:0{earlyminutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"Early {earlyhours}:{earlyminutes} hours before the start");
                    }

                }
                else
                {
                    if (earlyminutes < 10)
                    {
                        Console.WriteLine($"Early 0{earlyminutes} minutes before the start");
                    }
                    else
                    {
                        Console.WriteLine($"Early {earlyminutes} minutes before the start");

                    }
                }
            }

        }
    }
}


