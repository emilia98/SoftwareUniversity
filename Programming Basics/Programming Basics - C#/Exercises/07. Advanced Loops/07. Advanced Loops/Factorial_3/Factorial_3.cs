using System;

namespace Factorial_3
{
    class Factorial_3
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1, result = 1;

            while (i <= n)
            {
                result *= i;
                i++;
            }
            Console.WriteLine(result);
        }
    }
}
