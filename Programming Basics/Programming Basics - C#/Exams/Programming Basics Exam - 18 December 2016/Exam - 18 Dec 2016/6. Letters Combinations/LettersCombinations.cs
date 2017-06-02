using System;

namespace _6.Letters_Combinations
{
    class LettersCombinations
    {
        static void Main()
        {
            char startingLetting = char.Parse(Console.ReadLine());
            char endingLetter = char.Parse(Console.ReadLine());
            char skippingLetter = char.Parse(Console.ReadLine());

            int combinations = 0;

            for (char start1 = startingLetting; start1 <= endingLetter; start1++)
            {
                if (start1 == skippingLetter)
                {
                    continue;
                }
                for (char start2 = startingLetting; start2 <= endingLetter; start2++)
                {
                    if (start2 == skippingLetter)
                    {
                        continue;
                    }
                    for (char start3 = startingLetting; start3 <= endingLetter; start3++)
                    {
                        if (start3 == skippingLetter)
                        {
                            continue;
                        }
                        Console.Write("{0}{1}{2} ", start1, start2, start3);
                        combinations++;
                    }
                }
            }
            Console.WriteLine(combinations);
        }
    }
}
