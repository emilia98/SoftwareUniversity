using System;

namespace _09.MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int result = MultiplyEvensAndOdds(Math.Abs(number));
            Console.WriteLine(result);
        }

        static int MultiplyEvensAndOdds(int number)
        {
            int sumEvens = SumDigits(number, 0);           
            int sumOdds = SumDigits(number, 1);
            return sumEvens * sumOdds;
        }

        static int SumDigits(int number, int reminder)
        {
            int sum = 0;

            while(number > 0)
            {
                int currentDigit = number % 10;
                if(currentDigit % 2 == reminder)
                {
                    sum += currentDigit;
                }
                //Because number is int and if we divide 122 / 10, we get 12, but not 12.2;
                number /= 10;
            }
            return sum;
        }
    }
}
