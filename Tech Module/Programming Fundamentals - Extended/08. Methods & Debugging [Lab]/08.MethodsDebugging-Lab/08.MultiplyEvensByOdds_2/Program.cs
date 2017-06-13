using System;

namespace _08.MultiplyEvensByOdds_2
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int multiplyEvensByOdds = MultiplyEvensByOdds(number);
            Console.WriteLine(multiplyEvensByOdds);
        }

        static int SumOddDigits(int n)
        {
            int sum = 0;

            while(n > 0)
            {
                int lastDigit = n % 10;
                if(lastDigit % 2 == 1)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }

            return sum;
        }

        static int SumEvenDigits(int n)
        {
            int sum = 0;

            while(n > 0)
            {
                int lastDigit = n % 10;
                if(lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }

            return sum;
        }

        static int MultiplyEvensByOdds(int n)
        {
            int sumOfOddDigits = SumOddDigits(n);
            int sumOfEvenDigits = SumEvenDigits(n);
            return sumOfOddDigits * sumOfEvenDigits;
        }
    }
}
