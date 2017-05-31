using System;

namespace _03.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main()
        {
            ushort groupSize = ushort.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hallName = "";
            double pricePerPerson;
            double price = 0, discount;
            double percent = 0;

            if (groupSize <= 50)
            {
                hallName = "Small Hall";
                price += 2500;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hallName = "Terrace";
                price += 5000;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hallName = "Great Hall";
                price += 7500;
            }
            else
            {
                hallName = "";
            }

            if (package == "Normal")
            {
                price += 500;
                percent = 0.05;
            }
            else if (package == "Gold")
            {
                price += 750;
                percent = 0.1;
            }
            else if (package == "Platinum")  // of just else
            {
                price += 1000;
                percent = 0.15;
            }

            discount = price * percent;
            price = price - discount;

            pricePerPerson = price / groupSize;

            if(hallName != "")
            {
                Console.WriteLine("We can offer you the {0}", hallName);
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
