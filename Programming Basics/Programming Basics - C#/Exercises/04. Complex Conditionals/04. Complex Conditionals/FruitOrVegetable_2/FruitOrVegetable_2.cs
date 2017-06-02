using System;

namespace FruitOrVegetable_2
{
    class FruitOrVegetable_2
    {
        static void Main()
        {
            string product = Console.ReadLine();

            switch (product)
            {
                case "banana":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                case "apple":
                    {
                        Console.WriteLine("fruit");
                        break;
                    }
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    {
                        Console.WriteLine("vegetable");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("unknown");
                        break;
                    }
            }           
        }
    }
}
