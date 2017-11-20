using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_ElementsExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MinValue;
            int currentmax = 0;
            int count = 0;    

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > min)
                {
                    min = num;
                    count++;
                }
                else 
                {
                    if(count>currentmax)
                    {
                        count = currentmax;
                    }
                    count = 0;
                }

            }
            if (count > currentmax)
            {
                Console.WriteLine(count);

            }
            else
            {
                Console.WriteLine(currentmax);
            }
        }
    }
}
