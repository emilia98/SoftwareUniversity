using System;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int x, max;

            x = int.Parse(Console.ReadLine());
            max = x;

            for (int i = 1; i <= n-1 ;i++)
            {
                x = int.Parse(Console.ReadLine());
                if(max < x)
                {
                    max = x;
                }
            }
            Console.WriteLine(max);
        }
    }
}
