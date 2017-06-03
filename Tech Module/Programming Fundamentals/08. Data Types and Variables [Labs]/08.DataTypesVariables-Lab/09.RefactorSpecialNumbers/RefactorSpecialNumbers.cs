using System;

namespace _09.RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main()
        {
            int numbers = int.Parse(Console.ReadLine());

            for (int currentNumber = 1; currentNumber <= numbers; currentNumber++)
            {
                int sum = 0;
                int savedCurrentNumber = currentNumber;
                bool isSpecial = false;

                while (savedCurrentNumber > 0)
                {
                    sum += savedCurrentNumber % 10;
                    savedCurrentNumber = savedCurrentNumber / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentNumber} -> {isSpecial}");
            }
        }
    }
}
