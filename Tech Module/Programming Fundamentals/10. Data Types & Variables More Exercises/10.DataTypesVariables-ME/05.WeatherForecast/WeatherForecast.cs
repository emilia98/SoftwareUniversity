using System;

namespace _05.WeatherForecast
{
    class WeatherForecast
    {
        static void Main()
        {
            string number = Console.ReadLine();

            sbyte sbyteNumber;
            bool canFitInSByte = sbyte.TryParse(number, out sbyteNumber);
            int intNumber;
            bool canFitInInt = int.TryParse(number, out intNumber);
            long longNumber;
            bool canFitInLong = long.TryParse(number, out longNumber);
            double floatingPoint;
            bool canFitInDouble = double.TryParse(number, out floatingPoint);

            string weather = String.Empty;

            if (canFitInSByte)
            {
                weather = "Sunny";
            }
            else if (canFitInInt)
            {
                weather = "Cloudy";
            }
            else if (canFitInLong)
            {
                weather = "Windy";
            }
            else if (canFitInDouble)
            {
                weather = "Rainy";
            }

            Console.WriteLine(weather);
        }
    }
}
