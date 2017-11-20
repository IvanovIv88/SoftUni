using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bitcoins = decimal.Parse(Console.ReadLine());
            decimal yans = decimal.Parse(Console.ReadLine());
            decimal commision = decimal.Parse(Console.ReadLine());

            decimal bitcoinstoleva = bitcoins * 1168;
            decimal yanstodollars = yans * 0.15m;
            decimal yanstoleva = yanstodollars / 1.76m;

            decimal result = (bitcoinstoleva + yanstoleva) / 1.95m;

            decimal resultcommision = result - ((result * commision) / 100);

            Console.WriteLine(resultcommision);
      
        }
    }
}
