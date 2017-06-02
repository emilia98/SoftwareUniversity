using System;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main()
        {
            string month = Console.ReadLine().ToLower();
            uint days = uint.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApartment = 0;
            double studioCosts = 0;
            double apartmentCosts = 0;

            if (month == "may" || month == "october")
            {
                priceStudio = 50;
                priceApartment = 65;

                studioCosts = priceStudio * days;
                if (days > 7 && days <= 14)
                {
                    studioCosts = priceStudio * days * 0.95;
                }
                else if (days > 14)
                {
                    studioCosts = priceStudio * days * 0.7;
                }
            }

            else if (month == "june" || month == "september")
            {
                priceStudio = 75.20;
                priceApartment = 68.70;
                studioCosts = priceStudio * days;
                if (days > 14)
                {
                    studioCosts = priceStudio * days * 0.8;
                }
            }

            else if (month == "july" || month == "august")
            {
                priceStudio = 76;
                priceApartment = 77;

                studioCosts = priceStudio * days;
            }

            apartmentCosts = priceApartment * days;

            if(days > 14)
            {
                apartmentCosts = apartmentCosts * 0.9;
            }


            Console.WriteLine("Apartment: {0:f2} lv.", apartmentCosts);
            Console.WriteLine("Studio: {0:f2} lv.", studioCosts);
        }
    }
}
