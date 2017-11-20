using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double WorkingDay = double.Parse(Console.ReadLine());
            double EarnedMoney = double.Parse(Console.ReadLine());
            double ExchangeRate = double.Parse(Console.ReadLine());

            double EarnedMoneyforWorkingday = WorkingDay * EarnedMoney;
            double EarnedMoneyforYear = (EarnedMoneyforWorkingday * 12) + (EarnedMoneyforWorkingday * 2.5);
            double taxes = EarnedMoneyforYear * 0.25;
            double EardnedMoneyforYearWithTaxes = EarnedMoneyforYear - taxes;
            double EarnedMoneyforDaywithTaxes = EardnedMoneyforYearWithTaxes / 365;
            double EarnedMoneyfordaywithTaxesinleva = EarnedMoneyforDaywithTaxes * ExchangeRate;

            Console.WriteLine("{0:f2}", EarnedMoneyfordaywithTaxesinleva);
        }
    }
}
