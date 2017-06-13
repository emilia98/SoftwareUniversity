using System;

namespace _06.MathPower
{
    class MathPower
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = GetNumberOnPower(number, power);
            Console.WriteLine(result);
        }

        static double GetNumberOnPower(double number, int power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}
