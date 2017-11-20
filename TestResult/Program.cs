using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double Recordinsec = double.Parse(Console.ReadLine());
            double Distanceinmetric = double.Parse(Console.ReadLine());
            double Timeinseconds = double.Parse(Console.ReadLine());
            double Distaancefortime = Distanceinmetric * Timeinseconds;
            double lack2 = Math.Floor(Distanceinmetric / 15);
            double DistanceWithProblem = lack2 * 12.5;
            double TotalTime = Distaancefortime + DistanceWithProblem;
            double lack = Math.Abs(TotalTime- Recordinsec);

            if (Recordinsec <= TotalTime)
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", lack);
            else
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", TotalTime);
            }
        }
    }
}
