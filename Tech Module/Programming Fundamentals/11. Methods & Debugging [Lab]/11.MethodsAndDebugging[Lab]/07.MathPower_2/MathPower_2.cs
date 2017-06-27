using System;

namespace _07.MathPower_2
{
    class MathPower_2
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = GetPowerOfNumber(number, power);
            Console.WriteLine(result);
        }

        static double GetPowerOfNumber(double number, double power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}
