using System;

namespace _04.Hotel
{
    class Hotel
    {
        static void Main()
        {
            string month = Console.ReadLine();
            byte nightsCount = byte.Parse(Console.ReadLine());

            double priceStudio = 0, priceDouble = 0, priceSuite = 0;
            double discount = 0;

            if(month == "May" || month == "October")
            {
                priceStudio = 50 * nightsCount;
                priceDouble = 65 * nightsCount;
                priceSuite = 75 * nightsCount;
            }
            else if(month == "June" || month == "September")
            {
                priceStudio = 60 * nightsCount;
                priceDouble = 72 * nightsCount;
                priceSuite = 82 * nightsCount;
            }
            else if((month == "July" || month == "August") || month == "December")  //or just else
            {
                priceStudio = 68 * nightsCount;
                priceDouble = 77 * nightsCount;
                priceSuite = 89 * nightsCount;
            }

            //DISCOUNTS
            if ((month == "May" || month == "October") && (nightsCount > 7))
            {
                //IT MATTERS IF THE DISCOUNT IS CALCULATED BEFORE OR AFTER THE DECREASING OF STUDIO PRICE IN OCTOBER
                if (month == "October")
                {
                    priceStudio -= 50;
                }
                discount = priceStudio * 0.05;
                priceStudio -= discount;

            }
            else if ((month == "June" || month == "September") && (nightsCount > 14))
            {
                discount = priceDouble * 0.1;
                priceDouble -= discount;
            }
            else if( ((month == "July" || month == "August") || month == "December") && (nightsCount > 14))
            {
                discount = priceSuite * 0.15;
                priceSuite -= discount;
            }
            else if((month == "September") && (nightsCount > 7))
            {
                priceStudio -= 60;
            }

            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
            Console.WriteLine($"Double: {priceDouble:f2} lv.");
            Console.WriteLine($"Suite: {priceSuite:f2} lv.");
        }
    }
}
