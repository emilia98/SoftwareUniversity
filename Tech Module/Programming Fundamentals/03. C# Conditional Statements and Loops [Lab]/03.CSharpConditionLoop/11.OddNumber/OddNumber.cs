using System;

namespace _11.OddNumber
{
    class OddNumber
    {
        static void Main()
        {
            short number = short.Parse(Console.ReadLine());

            while(number % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                number = short.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The number is: {Math.Abs(number)}");
        }
    }
}
