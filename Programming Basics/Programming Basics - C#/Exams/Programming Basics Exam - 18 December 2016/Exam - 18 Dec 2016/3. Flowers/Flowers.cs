using System;

namespace _3.Flowers
{
    class Flowers
    {
        static void Main()
        {
            int hrizantemsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int tulipsCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char isHoliday = char.Parse(Console.ReadLine());

            const double hrizantemsPriceSprSum = 2.00;
            const double hrizantemsPriceAutWin = 3.75;
            const double rosesPriceSprSum = 4.10;
            const double rosesPriceAutWin = 4.50;
            const double tulipsPriceSprSum = 2.50;
            const double tulipsPriceAutWin = 4.15;

            double seasonPrice;
            double price;
            int allFlowers = hrizantemsCount + tulipsCount + rosesCount;

            if (season == "Spring" || season == "Summer")
            {
                seasonPrice = hrizantemsCount * hrizantemsPriceSprSum + rosesCount * rosesPriceSprSum +
                              tulipsCount * tulipsPriceSprSum;
                price = seasonPrice;

                if (isHoliday == 'Y')
                {
                    price = seasonPrice + seasonPrice * 0.15;

                    if (tulipsCount > 7 && season == "Spring")
                    {
                        price = 0.95 * price;
                    }
                }
                else
                {
                    if (tulipsCount > 7 && season == "Spring")
                    {
                        price = 0.95 * seasonPrice;
                    }
                }
            }
            else
            {
                seasonPrice = hrizantemsCount * hrizantemsPriceAutWin + rosesCount * rosesPriceAutWin +
                              tulipsCount * tulipsPriceAutWin;
                price = seasonPrice;

                if (isHoliday == 'Y')
                {
                    price = seasonPrice + seasonPrice * 0.15;

                    if (rosesCount >= 10 && season == "Winter")
                    {
                        price = 0.90 * price;
                    }
                }
                else
                {
                    if (rosesCount >= 10 && season == "Winter")
                    {
                        price = 0.90 * price;
                    }
                }
            }

            if (allFlowers >= 20)
            {
                price = price - price * 0.2;
            }

            price += 2;

            Console.WriteLine("{0:0.00}", price);
        }
    }
}
