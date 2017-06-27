using System;

namespace _05.TemperatureConversion
{
    class TemperatureConversion
    {
        static void Main()
        {
            double temperature = double.Parse(Console.ReadLine());
            double temperatureInCelsius = ConvertFromFahrenheitToCelsius(temperature);
            Console.WriteLine("{0:f2}", temperatureInCelsius);
        }

        static double ConvertFromFahrenheitToCelsius(double temperature)
        {
            double convertedValue = (temperature - 32) * 5 / 9;
            return convertedValue;
        }
    }
}
