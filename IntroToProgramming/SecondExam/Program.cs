using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examhours = int.Parse(Console.ReadLine());
            int examminutes = int.Parse(Console.ReadLine());
            int arrivehours = int.Parse(Console.ReadLine());
            int arriveminuts = int.Parse(Console.ReadLine());
            var latehours = 0;
            var lateminutes = 0;
            var ontimehours = arrivehours+1;
            var ontimeminuts = 0;
            if (examhours <= arrivehours)
            {
                if (examhours < arrivehours)
                {
                    latehours = (arrivehours - examhours);
                    lateminutes = Math.Abs(arriveminuts - examminutes);
                    if (lateminutes < 10)
                        Console.WriteLine($"Late {latehours}:0{lateminutes} minutes after the start");
                    else
                        Console.WriteLine($"Late {latehours}:{lateminutes} hours after the start");
                }
                if (examhours == arrivehours && examminutes < arriveminuts)
                {
                    lateminutes = Math.Abs(arriveminuts - examminutes);
                    if (lateminutes < 10)
                        Console.WriteLine($"Late 0{lateminutes} minutes after the start");
                    else
                        Console.WriteLine($"Late 0{lateminutes} minutes after the start");
                }
            }
            if (examhours == arrivehours && examminutes > arriveminuts)
            {
                ontimeminuts = examminutes - arriveminuts;
                Console.WriteLine($"On time {ontimeminuts} minutes before the start");
            }
            if (examhours == ontimehours && (arriveminuts + 30) - 60 >= examminutes)
              {
                 Console.WriteLine($"On time {Math.Abs(examminutes-arriveminuts)} minutes before the start");
              }
            }
        }
    }

