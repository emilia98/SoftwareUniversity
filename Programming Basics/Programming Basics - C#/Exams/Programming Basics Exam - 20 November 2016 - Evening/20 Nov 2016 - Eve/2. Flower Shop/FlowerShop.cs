using System;

namespace _2.Flower_Shop
{
    class FlowerShop
    {
        static void Main()
        {
            int magnolias = int.Parse(Console.ReadLine());
            int zumbuli = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            const double magnoliasPrice = 3.25;
            const double zumbuliPrice = 4;
            const double rosesPrice = 3.5;
            const double cactusesPrice = 8;

            double profit;
            double taxes;

            profit = magnolias * magnoliasPrice + zumbuli * zumbuliPrice + roses * rosesPrice + cactusesPrice * cactuses;
            taxes = 0.05 * profit;

            profit -= taxes;

            if (profit >= giftPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(profit - giftPrice));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(giftPrice - profit));
            }
        }
    }
}
