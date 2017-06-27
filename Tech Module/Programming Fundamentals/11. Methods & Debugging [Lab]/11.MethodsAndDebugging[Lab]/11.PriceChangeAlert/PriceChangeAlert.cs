using System;

namespace _11.PriceChangeAlert
{
    class PriceChangeAlert
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double previousPrice = double.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double differenceBetweenPrices = FindTheDifference(previousPrice, currentPrice);
                bool isSignificantDifference = IsSignificantDifference(threshold, differenceBetweenPrices);
                string message = GetAResult(currentPrice, previousPrice, differenceBetweenPrices, isSignificantDifference);
                Console.WriteLine(message);
                previousPrice = currentPrice;
            }
        }

        private static string GetAResult(double currentPrice, double previousPrice, 
                                    double differenceBetweenPrices, bool isSignificantDifference)
        {
            string result = "";
            if (differenceBetweenPrices == 0)
            {
                result = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificantDifference)
            {
                result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previousPrice, currentPrice,
                                                                     differenceBetweenPrices * 100.0);
            }
            else if (isSignificantDifference && (differenceBetweenPrices > 0))
            {
                result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, 
                                                                     differenceBetweenPrices * 100.0);
            }
            else if (isSignificantDifference && (differenceBetweenPrices < 0))
            {
                result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previousPrice, currentPrice,
                                                                     differenceBetweenPrices * 100.0);
            }                
            return result;
        }

        private static bool IsSignificantDifference(double threshold, double differenceBetweenPrices)
        {
            if (Math.Abs(differenceBetweenPrices) >= threshold)
            {
                {
                    return true;
                }
            }             
            return false;
        }

        private static double FindTheDifference(double previousPrice, double currentPrice)
        {
            double difference = (currentPrice - previousPrice) / previousPrice;
            return difference;
        }    
    }
}
