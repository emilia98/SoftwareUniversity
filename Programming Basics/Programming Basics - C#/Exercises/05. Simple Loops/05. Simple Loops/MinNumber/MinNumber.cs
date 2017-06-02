using System;

namespace MinNumber
{
    class MinNumber
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int x, min;

            x = int.Parse(Console.ReadLine());
            min = x;

            for (int i = 0; i < n - 1; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (min > x)
                {
                    min = x;
                }
            }
            Console.WriteLine(min);
        }
    }
}
