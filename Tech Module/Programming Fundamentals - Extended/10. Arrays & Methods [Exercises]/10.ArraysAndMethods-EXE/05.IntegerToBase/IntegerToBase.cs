using System;

namespace _05.IntegerToBase
{
    class IntegerToBase
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            string convertedNumber = ConvertNumberToBase(number, toBase);
            Console.WriteLine(convertedNumber);
        }

        static string ConvertNumberToBase(long number, int toBase)
        {
            string result = String.Empty;

            while(number > 0)
            {
                int reminder = (int)(number % toBase);
                result = reminder + result;
                number /= toBase;
            }
            return result;
        }
    }
}
