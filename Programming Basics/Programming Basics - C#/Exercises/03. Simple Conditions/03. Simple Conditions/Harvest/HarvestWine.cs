using System;

namespace Harvest
{
    class HarvestWine
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            //harvestForWine -> gives us the harvest's area for wine production
            double harvestForWine = x * 0.4;
            //kgGrapes -> gives is kilograms grapes needed
            double kgGrapes = y * harvestForWine;
            //
            double litersWine = kgGrapes / 2.5;

            if (litersWine < z)
            {
                double wineLacked = Math.Floor(z - litersWine);
                Console.WriteLine("It will be a tough winter! More {0:0} liters wine needed.", wineLacked);
            }
            else
            {
                //litersWine = Math.Floor(litersWine);  --> IT'S NOT OK, BECAUSE WE'LL USE THE REAL VALUE OF litersWine LATER
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(litersWine));
                double wineLeft = Math.Ceiling(litersWine - z);
                double winePerPerson = Math.Ceiling((wineLeft / workers));

                Console.WriteLine("{0} liters left -> {1} liters per person.",wineLeft,winePerPerson);
            }
        }
    }
}
