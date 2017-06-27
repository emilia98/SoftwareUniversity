using System;

namespace _02.SignOfIntegerNumber
{
    class SignOfIntegerNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string sign = SignOfNumber(number);
            Console.WriteLine("The number {0} is {1}.", number, sign);
        }

        static string SignOfNumber(int number)
        {
            string sign = String.Empty;
            if(number == 0)
            {
                sign = "zero";
            }
            else if(number > 0)
            {
                sign = "positive";
            }
            else
            {
                sign = "negative";
            }
            return sign;
        }
    }
}
