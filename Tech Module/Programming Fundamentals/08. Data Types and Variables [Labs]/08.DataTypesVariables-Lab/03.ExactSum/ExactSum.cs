using System;

namespace _03.ExactSum
{
    class ExactSum
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            decimal sum = 0m;

            for (uint i = 1; i <= n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number; 
            }
            Console.WriteLine(sum);
        }
    }
}
