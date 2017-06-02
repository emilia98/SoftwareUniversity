using System;

namespace _2.Transport_Price
{
    class TransportPrice
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();
            double minPrice = 0;

            if (n < 20)
            {
                if (partOfDay == "day")
                {
                    minPrice = n * 0.79 + 0.70;
                }
                else
                {
                    minPrice = n * 0.90 + 0.70;
                }
            }
            else if (n >= 20 && n < 100)
            {
                minPrice = n * 0.09;
            }
            else
            {
                minPrice = n * 0.06;
            }

            Console.WriteLine(minPrice);
        }
    }
}
