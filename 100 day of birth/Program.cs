using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_day_of_birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string myDate = Console.ReadLine();
            string format = "dd-MM-yyyy";

            var parsedDate = DateTime.ParseExact(myDate, format, null);
            parsedDate = parsedDate.AddDays(1000-1);
            Console.WriteLine(parsedDate.ToString(format));
        }
    }
}
