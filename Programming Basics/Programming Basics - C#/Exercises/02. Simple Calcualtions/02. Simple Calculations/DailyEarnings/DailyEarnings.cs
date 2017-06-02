using System;

namespace DailyEarnings
{
    class DailyEarnings
    {
        static void Main()
        {
            //n -> avg. number of days, Ivan works
            ushort n = ushort.Parse(Console.ReadLine());
            //m -> avg. money, Ivan earns per day
            double m = double.Parse(Console.ReadLine());
            double courseDtoLv = double.Parse(Console.ReadLine());

            double monthSalary = n * m;
            double bonus = monthSalary * 2.5;
            double yearEarnings = monthSalary * 12 + bonus;
            double taxes = yearEarnings * 0.25;

            double netSalaryDollars = yearEarnings - taxes;
            double netSalaryLv = netSalaryDollars * courseDtoLv;

            double averageEarningsDay = netSalaryLv / 365;

            Console.WriteLine("{0:0.00}",averageEarningsDay);
        }
    }
}
