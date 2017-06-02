using System;

namespace _3.Vacation
{
    class Vacation
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string accommodashion = "";
            string destination = "";
            double price;

            if (season == "Winter")
            {
                destination = "Morocco";

                if (budget <= 1000)
                {
                    accommodashion = "Camp";
                    price = budget * 0.45;
                }
                else if (budget > 1000 && budget <= 3000)
                {
                    accommodashion = "Hut";
                    price = budget * 0.60;
                }
                else
                {
                    accommodashion = "Hotel";
                    price = budget * 0.90;
                }
            }
            else
            {
                destination = "Alaska";

                if (budget <= 1000)
                {
                    accommodashion = "Camp";
                    price = budget * 0.65;
                }
                else if (budget > 1000 && budget <= 3000)
                {
                    accommodashion = "Hut";
                    price = budget * 0.80;
                }
                else
                {
                    accommodashion = "Hotel";
                    price = budget * 0.90;
                }
            }
            Console.WriteLine("{0} - {1} - {2:0.00}", destination, accommodashion, price);
        }
    }
}
