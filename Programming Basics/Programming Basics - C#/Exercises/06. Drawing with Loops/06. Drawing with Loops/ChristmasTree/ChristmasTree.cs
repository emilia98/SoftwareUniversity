using System;

namespace ChristmasTree
{
    class ChristmasTree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int intervalsEachHalf;
            int signsEachHalf;

            for (int i = 1; i <= n + 1; i++)
            {

                //For the first half of signs
                intervalsEachHalf = n + 1 - i;
                signsEachHalf = i - 1;

                for (int j = 1; j < (n * 2 + 3) / 2; j++)
                {
                    if (intervalsEachHalf > 0)
                    {
                        Console.Write(" ");
                        intervalsEachHalf--;
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

                //The middle of the Christmas Tree -> three signs - two intervals, between them there're one |
                Console.Write(" | ");

                intervalsEachHalf = n + 1 - i;
                signsEachHalf = i - 1;

                //The second half of the christmas tree
                for (int secondHalf = ((n * 2 + 3) / 2) + 3; secondHalf <= (n * 2 + 3); secondHalf++)
                {
                    if (signsEachHalf > 0)
                    {
                        Console.Write("*");
                        signsEachHalf--;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
