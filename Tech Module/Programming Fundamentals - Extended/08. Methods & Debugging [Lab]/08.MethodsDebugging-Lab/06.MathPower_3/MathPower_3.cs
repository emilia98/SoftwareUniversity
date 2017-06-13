using System;

namespace _06.MathPower_3
{
    class MathPower_3
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = GetNumberOnPower(number, power);
            Console.WriteLine(result);
        }

        //WITH RECURSION
        static double GetNumberOnPower(double number, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            else
            {
                return number * GetNumberOnPower(number, power - 1);
            }
        }
    }
}
