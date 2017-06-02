using System;

namespace SmallShops_2
{
    class SmallShops_2
    {
        static void Main()
        {
            string product = Console.ReadLine();
            string place = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());
            decimal howCosts = 0;

            place = place.ToLower();
            product = product.ToLower();

            switch(place)
            {
                case "sofia":
                    {
                        switch (product)
                        {
                            case "coffee":
                                {
                                    howCosts = 0.5m * quantity;
                                    break;
                                }
                            case "water":
                                {
                                    howCosts = 0.8m * quantity;
                                    break;
                                }
                            case "beer":
                                {
                                    howCosts = 1.2m * quantity;
                                    break;
                                }
                            case "sweets":
                                {
                                    howCosts = 1.45m * quantity;
                                    break;
                                }
                            case "peanuts":
                                {
                                    howCosts = 1.6m * quantity;
                                    break;
                                }
                            default:
                                {
                                    howCosts = 0;
                                    break;
                                }
                        }
                        break;
                    }
                   
                case "plovdiv":
                    {
                        switch (product)
                        {
                            case "coffee":
                                {
                                    howCosts = 0.4m * quantity;
                                    break;
                                }
                            case "water":
                                {
                                    howCosts = 0.7m * quantity;
                                    break;
                                }
                            case "beer":
                                {
                                    howCosts = 1.15m * quantity;
                                    break;
                                }
                            case "sweets":
                                {
                                    howCosts = 1.3m * quantity;
                                    break;
                                }
                            case "peanuts":
                                {
                                    howCosts = 1.5m * quantity;
                                    break;
                                }
                            default:
                                {
                                    howCosts = 0;
                                    break;
                                }
                        }
                        break;
                    }
                   
                case "varna":
                    {
                        switch (product)
                        {
                            case "coffee":
                                {
                                    howCosts = 0.45m * quantity;
                                    break;
                                }
                            case "water":
                                {
                                    howCosts = 0.7m * quantity;
                                    break;
                                }
                            case "beer":
                                {
                                    howCosts = 1.1m * quantity;
                                    break;
                                }
                            case "sweets":
                                {
                                    howCosts = 1.35m * quantity;
                                    break;
                                }
                            case "peanuts":
                                {
                                    howCosts = 1.55m * quantity;
                                    break;
                                }
                            default:
                                {
                                    howCosts = 0;
                                    break;
                                }
                        }
                        break;
                    }

                default:
                    {
                        howCosts = 0;
                        break;
                    }
            }
            Console.WriteLine(howCosts);
        }
    }
}
