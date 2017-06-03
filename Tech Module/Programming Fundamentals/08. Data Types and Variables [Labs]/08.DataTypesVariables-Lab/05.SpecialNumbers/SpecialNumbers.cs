using System;

namespace _05.SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            
            for (uint i = 1; i <= n; i++)
            {
                uint currentNumber = i;
                uint digit;
                uint sumOfDigits = 0;
                bool isSpecial = false;

                while (currentNumber != 0)
                {
                    digit = currentNumber % 10;
                    currentNumber -= digit;
                    currentNumber /= 10;

                    sumOfDigits += digit;

                }

                if (sumOfDigits == 5|| sumOfDigits == 7 || sumOfDigits == 11)
                {
                    isSpecial = true;
                }

                Console.WriteLine($"{i} -> {isSpecial}");
            } 
        }
    }
}
