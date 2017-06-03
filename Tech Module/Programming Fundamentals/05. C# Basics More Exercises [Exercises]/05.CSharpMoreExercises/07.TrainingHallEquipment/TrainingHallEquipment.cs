using System;

namespace _07.TrainingHallEquipment
{
    class TrainingHallEquipment
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            byte itemsNumber = byte.Parse(Console.ReadLine());

            string itemsName;
            double itemsPrice;
            short itemsCount;
            double subtotal = 0;

            for (byte i = 1; i <= itemsNumber; i++)
            {
                itemsName = Console.ReadLine();
                itemsPrice = double.Parse(Console.ReadLine());
                itemsCount = short.Parse(Console.ReadLine());

                if(itemsCount > 1)
                {
                    itemsName += "s";
                }

                subtotal += itemsCount * itemsPrice;

                Console.WriteLine($"Adding {itemsCount} {itemsName} to cart.");
            }

            Console.WriteLine("Subtotal: ${0:f2}", subtotal);

            if (subtotal > budget)
            {
                Console.WriteLine("Not enough. We need ${0:f2} more.", subtotal - budget);
            }
            else
            {
                Console.WriteLine("Money left: ${0:f2}", budget - subtotal);
            }
        }
    }
}
