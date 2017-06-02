using System;

namespace CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main()
        {
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine(Math.Round(fahrenheit,2));
        }
    }
}
