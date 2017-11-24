using System;
using System.Linq;

namespace _05.PizzaIngredients
{
    class PizzaIngredients
    {
        static void Main()
        {
            //input:
            var ingredients = Console.ReadLine().Split(' ').ToArray();
            int searchedLength = int.Parse(Console.ReadLine());

            var ingredientsUsed = new string[10];
            int counter = 0;

            foreach (var ingredient in ingredients)
            {
                if (ingredient.Length == searchedLength && counter < 10)
                {
                    ingredientsUsed[counter] = ingredient;
                    counter++;
                }
            }

            ingredientsUsed = ingredientsUsed.Skip(0).Take(counter).ToArray();

            foreach (var ingredient in ingredientsUsed)
            {
                Console.WriteLine($"Adding {ingredient}.");
            }

            Console.WriteLine($"Made pizza with total of {ingredientsUsed.Length} ingredients.");
            Console.WriteLine($"The ingredients are: {String.Join(", ", ingredientsUsed)}.");
            //goto input;
        }
    }
}
