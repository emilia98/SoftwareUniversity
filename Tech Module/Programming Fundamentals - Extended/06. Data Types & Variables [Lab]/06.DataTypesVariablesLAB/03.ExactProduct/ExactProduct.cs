using System;

namespace _03.ExactProduct
{
    class ExactProduct
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            decimal product = 1m;

            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                product *= number;
            }
            Console.WriteLine(product);
        }
    }
}
