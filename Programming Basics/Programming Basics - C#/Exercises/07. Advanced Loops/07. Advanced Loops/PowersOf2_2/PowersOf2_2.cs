using System;

namespace PowersOf2_2
{
    class PowersOf2_2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(result);
                result *= 2;
            }
        }
    }
}
