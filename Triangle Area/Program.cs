using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double shirochina = double.Parse(Console.ReadLine());
            double duljina = double.Parse(Console.ReadLine());
            double totalpieces = shirochina * duljina;
            double piecesnum = 0.00;

            if (shirochina >= 1 && shirochina <= 100 && duljina >= 1 && duljina <= 100)
            {
                for (int i = 0; i <= totalpieces; i--)
                {
                    string nu = "";
                    piecesnum = int.Parse(nu);
                    piecesnum = Convert.ToInt32(nu);
                    piecesnum = totalpieces - piecesnum;
                    totalpieces -= totalpieces;
                    if (piecesnum < 0)
                        Console.WriteLine($"No more cake left!You need {piecesnum:f2} pieces more.)");
                    else if (nu =="STOP")
                        Console.WriteLine(piecesnum);
                }
            
            }
        }
    }
}
