using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string firstRow = new string('*', n);
            Console.WriteLine(firstRow);

            for (int i = 0; i < n - 2; i++)
            {
                string row = "" + new string(' ', n - 2) + "";
                Console.WriteLine(row);
            }
            Console.WriteLine(firstRow);
        }
    }
}
    
