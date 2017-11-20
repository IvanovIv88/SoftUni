using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add1000
{
    class Program
    {
        static void Main(string[] args)
        {
            double holygdays = double.Parse(Console.ReadLine());
            double workingdays = 365 - holygdays;
            double playtime = (workingdays * 63) + (holygdays * 127);
            double tomsnormas = 30000 - playtime;
            double hrs = tomsnormas / 60;
            double mins = tomsnormas % 60;

            if (hrs < 0)
                Math.Floor(hrs);

            if (playtime > 30000)
            {
                if (hrs < 0)
                {
                    double hrs2 = Math.Floor(hrs);
                    Console.WriteLine("Tom will run away");
                    Console.WriteLine(Math.Abs(Math.Round(hrs2, 0)) + " hours and " + (Math.Abs(Math.Round(mins, 0)) + " minutes more for play"));
                }
            }

            else if (playtime < 30000)
            {
                if (hrs < 0)
                {
                    double hrs2 = Math.Floor(hrs);
                    Console.WriteLine("Tom sleeps well");
                    Console.WriteLine((Math.Round(hrs2, 0)) + " hours and " + (Math.Abs(Math.Round(mins, 0)) + " minutes less for play"));
                }
                else
                {
                    Console.WriteLine("Tom sleeps well");
                    Console.WriteLine((Math.Round(hrs, 0)) + " hours and " + (Math.Abs(Math.Round(mins, 0)) + " minutes less for play"));
                }
            }
        }
    }
}

