using System;
using System.Linq;

namespace _07.InventoryMatcher
{
    class InventoryMatcher
    {
        static void Main()
        {
            //input:
            var names = Console.ReadLine().Split(' ').ToArray();
            var quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            var productToFind = Console.ReadLine();

            while(productToFind != "done")
            {
                int index = Array.IndexOf(names, productToFind);
                string name = names[index];
                long quantity = quantities[index];
                decimal price = prices[index];

                Console.WriteLine($"{name} costs: {price}; Available quantity: {quantity}");
                productToFind = Console.ReadLine();
            }
            //goto input;
        }
    }
}
