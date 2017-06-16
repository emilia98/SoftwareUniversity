using System;

namespace _02.NumberChecker
{
    class NumberChecker
    {
        static void Main()
        {
            string number = Console.ReadLine();

            long integerNumber;
            bool isInteger = Int64.TryParse(number, out integerNumber);
            double floatingPointNumber;
            bool isFloatingPoint = double.TryParse(number, out floatingPointNumber);

            if (isInteger)
            {
                Console.WriteLine("integer");
            }
            else if (isFloatingPoint)
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
