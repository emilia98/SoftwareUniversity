using System;

namespace _02.AddTwoNumbers
{
    class AddTwoNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;

            Console.WriteLine("{0} + {1} = {2}", a, b, sum);
        }
    }
}
