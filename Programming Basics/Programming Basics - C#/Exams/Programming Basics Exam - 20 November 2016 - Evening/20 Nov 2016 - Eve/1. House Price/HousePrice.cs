using System;

namespace _1.House_Price
{
    class HousePrice
    {
        static void Main()
        {
            double smallestRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double pricePerSqrtM = double.Parse(Console.ReadLine());

            double bathroom = smallestRoom / 2;
            double secondRoom = smallestRoom * 0.1 + smallestRoom;
            double thirdRoom = secondRoom * 1.1;
            double area;
            double corridor;
            double apartmentPrice;

            area = smallestRoom + kitchen + bathroom + secondRoom + thirdRoom;
            corridor = area * 0.05;

            apartmentPrice = (area + corridor) * pricePerSqrtM;

            Console.WriteLine("{0:0.00}", apartmentPrice);
        }
    }
}
