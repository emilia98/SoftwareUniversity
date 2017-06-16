using System;

namespace _04.TouristInformation
{
    class TouristInformation
    {
        static void Main()
        {
            string imperialUnit = Console.ReadLine();
            double valueToConvert = double.Parse(Console.ReadLine());

            double convertedValue = 0;
            string metricUnit = String.Empty;

            if (imperialUnit == "miles")
            {
                convertedValue = 1.6 * valueToConvert;
                metricUnit = "kilometers";
            }
            else if (imperialUnit == "inches")
            {
                convertedValue = 2.54 * valueToConvert;
                metricUnit = "centimeters";
            }
            else if (imperialUnit == "feet")
            {
                convertedValue = 30 * valueToConvert;
                metricUnit = "centimeters";
            }
            else if (imperialUnit == "yards")
            {
                convertedValue = 0.91 * valueToConvert;
                metricUnit = "meters";
            }
            else if (imperialUnit == "gallons")
            {
                convertedValue = 3.8 * valueToConvert;
                metricUnit = "liters";
            }

            Console.WriteLine("{0} {1} = {2:f2} {3}", valueToConvert, imperialUnit, convertedValue, metricUnit);
        }
    }
}
