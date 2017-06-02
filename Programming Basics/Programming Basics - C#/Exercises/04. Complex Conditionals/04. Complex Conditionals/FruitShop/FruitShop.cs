using System;

namespace FruitShop
{
    class FruitShop
    {
        static void Main()
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            bool invalidData = false;

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana")
                {
                    price = 2.5 * quantity;
                }
                else if (fruit == "apple")
                {
                    price = 1.2 * quantity;
                }
                else if (fruit == "orange")
                {
                    price = 0.85 * quantity;
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45 * quantity;
                }
                else if (fruit == "kiwi")
                {
                    price = 2.7 * quantity;
                }
                else if (fruit == "pineapple")
                {
                    price = 5.5 * quantity;
                }
                else if (fruit == "grapes")
                {
                    price = 3.85 * quantity;
                }
                else
                {
                    invalidData = true;
                }
            }

            else if(day == "saturday" || day =="sunday")
            {
                switch(fruit)
                {
                    case "banana":
                        {
                            price = quantity * 2.7;
                            break;
                        }
                    case "apple":
                        {
                            price = quantity * 1.25;
                            break;
                        }
                    case "orange":
                        {
                            price = quantity * 0.9;
                            break;
                        }
                    case "grapefruit":
                        {
                            price = quantity * 1.6;
                            break;
                        }
                    case "kiwi":
                        {
                            price = quantity * 3;
                            break;
                        }
                    case "pineapple":
                        {
                            price = quantity * 5.6;
                            break;
                        }
                    case "grapes":
                        {
                            price = quantity * 4.2;
                            break;
                        }
                    default:
                        {
                            invalidData = true;
                            break;
                        }
                }
            }

            else
            {
                invalidData = true;
            }

            if(invalidData)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:0.00}",price);
            }

        }
    }
}
