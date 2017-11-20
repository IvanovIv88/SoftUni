using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int specialnumber = int.Parse(Console.ReadLine());
            int controlnumber = int.Parse(Console.ReadLine());
            bool control = false;
            int lastrecord = 0;

            for (int n1 = n; n1 >= 1; n1--)
            {
                for (int m1 = m; m1 >= 1; m1--)
                {
                    for (int l1 = l; l1 >= 1; l1--)
                    {
                        int number = (n1 * 100) + (m1 * 10) + l1;
                        if (specialnumber >= controlnumber)
                        {
                            lastrecord = specialnumber;
                            control = true;
                        }
                        else if (number % 3 == 0)
                            specialnumber = specialnumber + 5;
                        else if (l1 == 5)
                            specialnumber = specialnumber - 2;
                        else if (number % 2 == 0)
                            specialnumber = specialnumber * 2;
                    }
                }
            }
            if(control == true)
            {
                Console.WriteLine($"Yes! Control number was reached! Current special number is {lastrecord}.");
            }
            else
            {
                Console.WriteLine($"No! {specialnumber} is the last reached special number.");
            }
        }
    }
}