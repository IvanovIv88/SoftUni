using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string a = Console.ReadLine();
            bool choice = int.TryParse(a, out num);
            int i;
            int k;
            if ((choice == true) && ((((num > 2) || (num == 2))) && ((num < 100) || (num == 100))))
            {

                for (i = 0; i < num; i++)
                {
                    for (k = 0; k < num - 1; k++)
                    {
                        if (i > 0 && k > 0)
                        {
                            if ((i < num - 1) && (k < num - 1))
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("*");
                            }
                        }
                        else
                        {
                            Console.Write("*");
                        }


                    }
                    Console.WriteLine("*");
                }

            }

        }




    }

}


