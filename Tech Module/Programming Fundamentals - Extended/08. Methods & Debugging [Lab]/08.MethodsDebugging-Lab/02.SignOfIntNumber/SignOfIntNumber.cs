using System;

namespace _02.SignOfIntNumber
{
    class SignOfIntNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            GetSign(number);
        }

        static void GetSign(int n)
        {
            string numberType = String.Empty;
            if (n > 0)
            {
                numberType = "positive";
            }
            else if (n < 0)
            {
                numberType = "negative";
            }
            else
            {
                numberType = "zero";
            }
            Console.WriteLine($"The number {n} is {numberType}.");
        }
    }
}
