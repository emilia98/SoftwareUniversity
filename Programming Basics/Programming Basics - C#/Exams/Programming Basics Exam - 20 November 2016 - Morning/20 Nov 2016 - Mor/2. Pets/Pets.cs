using System;

namespace _2.Pets
{
    class Pets
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double foodDogPerDay = double.Parse(Console.ReadLine());
            double foodCatPerDay = double.Parse(Console.ReadLine());
            double foodTurtlePerDay = double.Parse(Console.ReadLine());

            double foodNeeded;
            foodNeeded = (foodDogPerDay + foodCatPerDay + foodTurtlePerDay / 1000) * days;

            if (foodNeeded <= food)
            {
                foodNeeded = Math.Ceiling(foodNeeded);
                Console.WriteLine("{0} kilos of food left.", food - foodNeeded);
            }
            else
            {
                foodNeeded = Math.Ceiling(foodNeeded);
                Console.WriteLine("{0} more kilos of food are needed.", foodNeeded - food);
            }
        }
    }
}
