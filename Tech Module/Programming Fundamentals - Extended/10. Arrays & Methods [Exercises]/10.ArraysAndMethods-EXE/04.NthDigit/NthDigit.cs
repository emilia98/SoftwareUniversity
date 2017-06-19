using System;

namespace _04.NthDigit
{
    class NthDigit
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            string numberToString = number.ToString();
            int nthDigit = FindNthDigit(number, index);
            Console.WriteLine(nthDigit);
        }

        static int FindNthDigit(long number,int index)
        {
            string numberToString = number.ToString();
            int digits = numberToString.Length;
            int nthDigit = int.Parse(numberToString[digits - index].ToString());
            return nthDigit;
        }
    }
}
