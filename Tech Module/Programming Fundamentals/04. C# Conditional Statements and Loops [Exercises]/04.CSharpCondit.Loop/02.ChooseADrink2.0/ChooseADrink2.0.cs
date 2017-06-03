using System;

namespace _02.ChooseADrink2._0
{
    class ChooseADrink2_0
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price;

            if(profession == "Athlete")
            {
                price = 0.7 * quantity;
            }
            else if(profession == "Businessman" || profession == "Businesswoman")
            {
                price = 1.0 * quantity;
            }
            else if (profession == "SoftUni Student")
            {
                price = 1.7 * quantity;
            }
            else
            {
                price = 1.2 * quantity;
            }

            Console.WriteLine("The {0} has to pay {1:f2}.", profession, price);
        }
    }
}
