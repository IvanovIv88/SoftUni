using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var n5 = int.Parse(Console.ReadLine());
            var sum = int.Parse(Console.ReadLine());

            for (int lv1 = 0; lv1 <= n1; lv1++)
            {
                for (int lv2 = 0; lv2 <= n2; lv2++)
                {
                    for (int lv5 = 0; lv5 <= n5; lv5++)
                    {
                        if ((lv1 * 1) + (lv2 * 2) + (lv5 * 5) == sum)
                            Console.WriteLine($"{lv1} * 1 lv. + {lv2} * 2 lv. + {lv5} * 5 lv. = {sum} lv." );
                    }
                }
            }
        }
    }
}
