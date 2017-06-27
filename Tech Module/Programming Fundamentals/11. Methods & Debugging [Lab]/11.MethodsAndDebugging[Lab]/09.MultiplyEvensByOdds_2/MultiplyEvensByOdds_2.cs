using System;

namespace _09.MultiplyEvensByOdds_2
{
    class MultiplyEvensByOdds_2
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int result = MultiplyEvensWithOdds(Math.Abs(number));
            Console.WriteLine(result);
        }

        static int MultiplyEvensWithOdds(int number)
        {
            int sumEvens = SumDigits(number, 0);
            int sumOdds = SumDigits(number, 1);
            return sumEvens * sumOdds;
        }

        static int SumDigits(int number, int reminder)
        {
            int sum = 0;
            string numberAsString = number.ToString();
            int digitsCount = numberAsString.Length;

            for (int i = 0; i < digitsCount; i++)
            {
                int currentDigit = int.Parse(numberAsString[i].ToString());
                if(currentDigit % 2 == reminder)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }
    }
}
