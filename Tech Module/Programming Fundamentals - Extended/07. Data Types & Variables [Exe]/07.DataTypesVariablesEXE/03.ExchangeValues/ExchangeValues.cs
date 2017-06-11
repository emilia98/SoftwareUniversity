using System;

namespace _03.ExchangeValues
{
    class ExchangeValues
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            int tempVariable = a;
            a = b;
            b = tempVariable;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
