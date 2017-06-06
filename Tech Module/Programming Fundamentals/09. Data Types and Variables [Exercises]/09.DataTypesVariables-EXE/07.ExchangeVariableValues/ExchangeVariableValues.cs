using System;

namespace _07.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5, b = 10;
            int tempValue = a;
            a = b;
            b = tempValue;

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {b}");
            Console.WriteLine($"b = {a}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
