using System;

namespace _01.ReverseString_2
{
    class ReverseString_2
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string reversedInput = String.Empty;

            for (int index = input.Length - 1; index >= 0; index--)
            {
                reversedInput += input[index];
            }
            Console.WriteLine(reversedInput);
        }
    }
}
