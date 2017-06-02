using System;

namespace SmallShops
{
    class SmallShops
    {
        static void Main()
        {
            string product = Console.ReadLine();
            string place = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());
            decimal howCosts = 0;

            place = place.ToLower();
            product = product.ToLower();
           
            if (product == "coffee")
            {
                if (place == "sofia")
                {
                    howCosts = 0.5m * quantity;
                }
                else if (place == "plovdiv")
                {
                    howCosts = 0.4m * quantity;
                }
                else if (place == "varna")
                {
                    howCosts = 0.45m * quantity;
                }
            }

            else if (product == "water")
            {
                if (place == "sofia")
                {
                    howCosts = 0.8m * quantity;
                }
                else if (place == "plovdiv")
                {
                    howCosts = 0.7m * quantity;
                }
                else if (place == "varna")
                {
                    howCosts = 0.7m * quantity;
                }
            }

            else if (product == "beer")
            {
                if (place == "sofia")
                {
                    howCosts = 1.2m * quantity;
                }
                else if (place == "plovdiv")
                {
                    howCosts = 1.15m * quantity;
                }
                else if (place == "varna")
                {
                    howCosts = 1.10m * quantity;
                }
            }

            else if (product == "sweets")
            {
                if (place == "sofia")
                {
                    howCosts = 1.45m * quantity;
                }
                else if (place == "plovdiv")
                {
                    howCosts = 1.3m * quantity;
                }
                else if (place == "varna")
                {
                    howCosts = 1.35m * quantity;
                }
            }

            else if (product == "peanuts")
            {
                if (place == "sofia")
                {
                    howCosts = 1.6m * quantity;
                }
                else if (place == "plovdiv")
                {
                    howCosts = 1.5m * quantity;
                }
                else if(place == "varna")
                {
                    howCosts = 1.55m * quantity;
                }
            }
            Console.WriteLine(howCosts);
        }
    }
}
