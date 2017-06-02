using System;

namespace Factorial_2
{
    class Factorial_2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result = 1;
            do
            {
                result *= n;
                n--;
            }
            while (n > 1);

            Console.WriteLine(result);
        }
    }
}
