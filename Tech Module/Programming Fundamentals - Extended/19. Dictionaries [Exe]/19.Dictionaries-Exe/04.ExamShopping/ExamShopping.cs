using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ExamShopping
{
    class ExamShopping
    {
        static void Main()
        {
            string str = Console.ReadLine();
            Dictionary<string, int> inventory = new Dictionary<string, int>();

            AddProductToInventory(inventory, str);
            str = Console.ReadLine();
            BuyProductFromInventory(inventory, str);
            PrintTheResult(inventory);
        }

        static Dictionary<string, int> AddProductToInventory(Dictionary<string, int> inventory, string str)
        {
            while (true)
            {
                if (str == "shopping time")
                {
                    break;
                }
                string[] splitedInput = str.Split(' ').ToArray();
                string productName = splitedInput[1];
                int quantity = int.Parse(splitedInput[2]);

                if (!inventory.ContainsKey(productName))
                {
                    inventory.Add(productName, 0);
                }
                inventory[productName] += quantity;

                str = Console.ReadLine();
            }
            return inventory;
        }

        static Dictionary<string, int> BuyProductFromInventory(Dictionary<string, int> inventory, string str)
        {
            while (true)
            {
                if (str == "exam time")
                {
                    break;
                }
                string[] splitedInput = str.Split(' ').ToArray();
                string productName = splitedInput[1];
                int quantityToBuy = int.Parse(splitedInput[2]);

                //If in the inventory there isn't a product with given name
                if (!inventory.ContainsKey(productName))
                {
                    Console.WriteLine("{0} doesn't exist", productName);
                }
                //If we don't have any of the product wiht given name
                else if(inventory[productName] == 0)
                {
                    Console.WriteLine("{0} out of stock", productName);
                }
                else
                {
                    //If we have enough of the product, we could sell the given quantity
                    if (inventory[productName] - quantityToBuy >= 0)
                    {
                        inventory[productName] -= quantityToBuy;
                    }
                    //If we don't have enough of the product, we could sell the quantity we have 
                    //(if there is any)
                    else if (inventory[productName] - quantityToBuy < 0 )
                    {
                        inventory[productName] = 0;
                    }
                }
                str = Console.ReadLine();
            }
            return inventory;
        }

        static void PrintTheResult(Dictionary<string, int> inventory)
        {
            foreach (string product in inventory.Keys)
            {
                if (inventory[product] > 0)
                {
                    Console.WriteLine("{0} -> {1}", product, inventory[product]);
                }
            }
        }
    }
}
