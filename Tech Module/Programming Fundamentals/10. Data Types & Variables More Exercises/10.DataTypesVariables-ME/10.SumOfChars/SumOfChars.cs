using System;

namespace _10.SumOfChars
{
    class SumOfChars
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            uint sum = 0;

            for (uint i = 1; i <= n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                sum += ch;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
