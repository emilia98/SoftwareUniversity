using System;

namespace _08.Increasing_Elements
{
    class IncreasingElements
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else if (n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {

                int x = int.Parse(Console.ReadLine());
                int previousElement = x;
                int counter = 1, maxCounter = 0;

                for (int i = 2; i <= n; i++)
                {
                    x = int.Parse(Console.ReadLine());

                    if (x <= previousElement)
                    {
                        if (maxCounter < counter)
                        {
                            maxCounter = counter;
                        }
                        counter = 1;
                        previousElement = x;
                        continue;
                    }
                    previousElement = x;
                    counter++;
                }

                if (maxCounter < counter)
                {
                    Console.WriteLine(counter);
                }
                else
                {
                    Console.WriteLine(maxCounter);
                }
            }
        }
    }
}
