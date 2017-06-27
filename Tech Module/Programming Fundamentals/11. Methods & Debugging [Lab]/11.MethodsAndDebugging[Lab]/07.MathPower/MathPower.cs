using System;

namespace _07.MathPower
{
    class MathPower
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = GetPowerOfNumber(number, power);
            Console.WriteLine(result);
        }

        static double GetPowerOfNumber(double number, int power)
        {
            double result = number;
            if (power == 0)
            {
                return 1;
            }

            for (int pow = 2; pow <= power; pow++)
            {
                result *= number;
            }
            return result;
        }

        /*  OR
             static double GetPowerOfNumber(double number, int power)
             {
                double result = 1.0;

                for (int pow = 1; pow <= power; pow++)
                {
                    result *= number;
                }
                return result;
            }
        */
    }
}
