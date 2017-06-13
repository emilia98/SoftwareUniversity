using System;

namespace _10.PriceChangeAlert
{
    class PriceChangeAlert
    {
        static void Main()
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double previousPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double difference = FindDifference(previousPrice, currentPrice);
                bool isSignificantDifference = FindSignificantDifference(difference, threshold);
                string message = GetMessage(currentPrice, previousPrice, difference, isSignificantDifference);
                Console.WriteLine(message);
                previousPrice = currentPrice;
            }
        }

        static string GetMessage(double currentPrice, double previousPrice, double difference, bool isSignigicantDifference)
        {
            string kindOfChange = "";

            if (difference == 0)
            {
                kindOfChange = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignigicantDifference)
            {
                kindOfChange = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference * 100);
            }
            else if (isSignigicantDifference && (difference > 0))
            {
                kindOfChange = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference * 100);
            }
            else if (isSignigicantDifference && (difference < 0))
            {
                kindOfChange = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference *100);
            }     
            return kindOfChange;
        }

        static bool FindSignificantDifference(double difference, double threshold)
        {
            if (Math.Abs(difference) >= threshold)
            {
                return true;
            }
            return false;
        }

        static double FindDifference(double previousPrice, double currentPrice)
        {
            double difference = (currentPrice - previousPrice)  / previousPrice;
            return difference;
        }
    }

}

