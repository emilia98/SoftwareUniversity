using System;

namespace USDtoBGN
{
    class USDtoBGN
    {
        static void Main()
        {
            double dollars = double.Parse(Console.ReadLine());
            double leva = dollars * 1.79549;

            Console.WriteLine("{0} BGN",Math.Round(leva,2));
        }
    }
}
