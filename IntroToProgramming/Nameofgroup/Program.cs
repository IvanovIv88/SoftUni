using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nameofgroup
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            char d = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char atolow = char.ToLower(a);
            int totalsum = 0;

            for (var a1 = 'a'; a1 <= atolow; a1++)
            {
                for (char b1 = 'a'; b1 <= b; b1++)
                {
                    for (char c1 = 'a'; c1 <= c; c1++)
                    {
                        for (char d1 = 'a'; d1 <= d; d1++)
                        {
                            for (int n1 = 0; n1 <= n; n1++)
                            {
                                totalsum = totalsum + 1;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(totalsum-1);
        }
    }
}
