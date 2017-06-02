using System;

namespace _4.SoftUni_Camp
{
    class SoftUniCamp
    {
        static void Main()
        {
            uint groups = uint.Parse(Console.ReadLine());
            uint peopleCount;
            uint allPeople = 0;
            uint peopleWithCar = 0;
            uint peopleWithMicrobus = 0;
            uint peopleWithSmallBus = 0;
            uint peopleWithBigBus = 0;
            uint peopleWithTrain = 0;

            for (uint group = 1; group <= groups; group++)
            {
                peopleCount = uint.Parse(Console.ReadLine());
                allPeople += peopleCount;

                if (peopleCount <= 5)
                {
                    peopleWithCar += peopleCount;
                }
                else if (peopleCount > 5 && peopleCount < 13)
                {
                    peopleWithMicrobus += peopleCount;
                }
                else if (peopleCount >= 13 && peopleCount <= 25)
                {
                    peopleWithSmallBus += peopleCount;
                }
                else if (peopleCount > 25 && peopleCount < 41)
                {
                    peopleWithBigBus += peopleCount;
                }
                else
                {
                    peopleWithTrain += peopleCount;
                }
            }

            double percentageWithCar = (peopleWithCar * 1.0 / allPeople) * 100;
            double percentageWithMircobus = (peopleWithMicrobus * 1.0 / allPeople) * 100;
            double percentageWithSmallBus = (peopleWithSmallBus * 1.0 / allPeople) * 100;
            double percentageWithBigBus = (peopleWithBigBus * 1.0 / allPeople) * 100;
            double percentageWithTrain = (peopleWithTrain * 1.0 / allPeople) * 100;

            Console.WriteLine("{0:0.00}%", percentageWithCar);
            Console.WriteLine("{0:f2}%", percentageWithMircobus);
            Console.WriteLine("{0:0.00}%", percentageWithSmallBus);
            Console.WriteLine("{0:f2}%", percentageWithBigBus);
            Console.WriteLine("{0:0.00}%", percentageWithTrain);
        }
    }
}
