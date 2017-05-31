using System;

namespace _08.CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main()
        {
            int ingredientsNumber = int.Parse(Console.ReadLine());
            int calories = 0;
            string ingredient;

            for (int i = 1; i <= ingredientsNumber; i++)
            {
                ingredient = Console.ReadLine().ToLower();

                if(ingredient == "cheese")
                {
                    calories += 500;
                }
                else if(ingredient == "tomato sauce")
                {
                    calories += 150;
                }
                else if (ingredient == "salami")
                {
                    calories += 600;
                }
                else if (ingredient == "pepper")
                {
                    calories += 50;
                }
                else
                {
                    calories += 0;
                }
            }

            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
