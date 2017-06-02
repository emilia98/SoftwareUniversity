using System;

namespace _4.Logistics
{
    class Logistics
    {
        static void Main()
        {
            int cargoCount = int.Parse(Console.ReadLine());
            int cargo;

            const double microbusPrice = 200;
            const double truckPrice = 175;
            const double trainPrice = 120;

            int allCargosWeight = 0;
            int microbusCount = 0;
            int truckCount = 0;
            int trainCount = 0;

            for (int i = 1; i <= cargoCount; i++)
            {
                cargo = int.Parse(Console.ReadLine());
                allCargosWeight += cargo;

                if (cargo <= 3)
                {
                    microbusCount += cargo;
                }
                else if (cargo > 3 && cargo < 12)
                {
                    truckCount += cargo;
                }
                else
                {
                    trainCount += cargo;
                }
            }

            double averagePricePerTone = (microbusPrice * microbusCount + truckCount * truckPrice + trainCount * trainPrice) / allCargosWeight;

            Console.WriteLine("{0:f2}", averagePricePerTone);

            double percentageMicrobus = (microbusCount * 1.0 / allCargosWeight) * 100;
            double percentageTruck = (truckCount * 1.0 / allCargosWeight) * 100;
            double percentageTrain = (trainCount * 1.0 / allCargosWeight) * 100;

            Console.WriteLine("{0:0.00}%", percentageMicrobus);
            Console.WriteLine("{0:0.00}%", percentageTruck);
            Console.WriteLine("{0:0.00}%", percentageTrain);
        }
    }
}
