using System;

namespace _3.Vacation
{
    class Vacation
    {
        static void Main()
        {
            int adults = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string typeTransport = Console.ReadLine();

            const double adultsTrain = 24.99;
            const double studentsTrain = 14.99;
            const double adultsBus = 32.50;
            const double studentsBus = 28.50;
            const double adultsBoat = 42.99;
            const double studentsBoat = 39.99;
            const double adultsPlane = 70.00;
            const double studentsPlane = 50.00;

            const double nightsPrice = 82.99;

            double holidaySum, allSum;
            double commission;
            double transportPrice;
            double hotel = nights * nightsPrice;

            if (typeTransport == "train")
            {
                transportPrice = (adults * adultsTrain + students * studentsTrain) * 2;

                if ((adults + students) >= 50)
                {
                    transportPrice = transportPrice / 2;
                }
            }
            else if (typeTransport == "bus")
            {
                transportPrice = (adults * adultsBus + students * studentsBus) * 2;
            }
            else if (typeTransport == "boat")
            {
                transportPrice = (adults * adultsBoat + students * studentsBoat) * 2;
            }
            else
            {
                transportPrice = (adults * adultsPlane + students * studentsPlane) * 2;
            }

            holidaySum = transportPrice + hotel;
            commission = holidaySum * 0.1;
            allSum = holidaySum + commission;

            Console.WriteLine("{0:f2}", allSum);
        }
    }
}
