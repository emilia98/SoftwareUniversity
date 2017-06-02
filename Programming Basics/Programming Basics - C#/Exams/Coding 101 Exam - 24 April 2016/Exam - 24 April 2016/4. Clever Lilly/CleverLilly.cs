using System;

namespace _4.Clever_Lilly
{
    class CleverLilly
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            uint toys_price = uint.Parse(Console.ReadLine());
            uint hb_money = 0, counter_toys = 0;
            uint collectedMoney;

            for (uint age = 1; age <= n; age++)
            {
                if (age % 2 == 0)
                {
                    hb_money += age * 5 - 1;
                }
                else
                {
                    counter_toys++;
                }
            }

            collectedMoney = hb_money + counter_toys * toys_price;

            if (collectedMoney >= x)
            {
                Console.WriteLine("Yes! {0:0.00}", collectedMoney - x);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", x - collectedMoney);
            }
        }
    }
}
