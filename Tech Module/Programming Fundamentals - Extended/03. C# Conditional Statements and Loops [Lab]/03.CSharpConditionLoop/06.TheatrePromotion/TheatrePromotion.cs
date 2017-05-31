using System;

namespace _06.TheatrePromotion
{
    class TheatrePromotion
    {
        static void Main()
        {
            string typeOfDay = Console.ReadLine().ToLower();
            short age = short.Parse(Console.ReadLine());
            byte price = 0;

            if (age >= 0 && age <= 18)
            {
                if (typeOfDay == "holiday")
                {
                    price = 5;
                }
                else if (typeOfDay == "weekday")
                {
                    price = 12;
                }
                else
                {
                    price = 15;
                }

                Console.WriteLine("{0}$", price);
            }
            else if (age > 18 && age <= 64)
            {
                if (typeOfDay == "holiday")
                {
                    price = 12;
                }
                else if (typeOfDay == "weekday")
                {
                    price = 18;
                }
                else
                {
                    price = 20;
                }

                Console.WriteLine("{0}$", price);
            }
            else if (age > 64 && age <= 122)
            {
                if (typeOfDay == "holiday")
                {
                    price = 10;
                }
                else if (typeOfDay == "weekday")
                {
                    price = 12;
                }
                else
                {
                    price = 15;
                }

                Console.WriteLine("{0}$", price);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

    }
}
