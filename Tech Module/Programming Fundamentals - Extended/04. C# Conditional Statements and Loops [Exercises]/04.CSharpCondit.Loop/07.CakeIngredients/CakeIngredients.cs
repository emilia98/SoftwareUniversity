using System;

namespace _07.CakeIngredients
{
    class CakeIngredients
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int ingredientCount = 0;

            while(text != "Bake!")
            {
                ingredientCount++;
                Console.WriteLine("Adding ingredient {0}.", text);
                text = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {ingredientCount} ingredients.");
        }
    }
}
