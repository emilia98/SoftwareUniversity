using System;

namespace NumberTable
{
    class NumberTable
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                if (row == 1)
                {
                    for (int number = 1; number <= n; number++)
                    {
                        Console.Write("{0} ", number);
                    }
                }
                else if (row == n)
                {
                    for (int number = n; number > 0; number--)
                    {
                        Console.Write("{0} ", number);
                    }
                }
                else
                {
                    for (int number = row; number <= n; number++)
                    {
                        Console.Write("{0} ", number);
                    }

                    int numbersLeft = n - row + 1;
                    for (int number = n - 1; number >= numbersLeft; number--)
                    {
                        Console.Write("{0} ", number);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
