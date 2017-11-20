using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double poormark = 0;
            double satismark = 0;
            double goodmark = 0;
            double verygoodmark = 0;
            double exmark = 0;

            for (int i = 0; i < n; i++)
            {
                double mark = double.Parse(Console.ReadLine());
                if(mark >= 0 && mark < 22.5)
                {
                    poormark++;
                }
                if(mark >= 22.5 && mark < 40.5)
                {
                    satismark++;
                }
                if(mark >= 40.5 && mark < 58.5)
                {
                    goodmark++;
                }
                if(mark >= 58.5 && mark < 76.5)
                {
                    verygoodmark++;
                }
                if(mark >= 76.5 && mark <= 100)
                {
                    exmark++;
                }
            }
            double totalpoor = (poormark / n) * 100;
            double totalsatis = (satismark / n) * 100;
            double totalgood = (goodmark / n) * 100;
            double totalverygood = (verygoodmark / n) * 100;
            double totalsexmark = (exmark / n) * 100;
            Console.WriteLine($"{totalpoor:f2}% poor marks");
            Console.WriteLine($"{totalsatis:f2}% satisfactory marks");
            Console.WriteLine($"{totalgood:f2}% good marks");
            Console.WriteLine($"{totalverygood:f2}% very good marks");
            Console.WriteLine($"{totalsexmark:f2}% excellent marks");
        }
    }
}
