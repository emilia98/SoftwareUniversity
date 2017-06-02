using System;

namespace _6.Max_Combination
{
    class MaxCombination
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maxCombinations = int.Parse(Console.ReadLine());

            int combinationsCount = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combinationsCount++;

                    if (combinationsCount > maxCombinations)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("<{0}-{1}>", i, j);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
