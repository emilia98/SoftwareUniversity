using System;

namespace _06.MathPower_2
{
    class MathPower_2
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
            double result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
