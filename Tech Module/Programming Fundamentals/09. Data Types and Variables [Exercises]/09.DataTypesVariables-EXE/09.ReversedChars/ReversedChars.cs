using System;

namespace _09.ReversedChars
{
    class ReversedChars
    {
        static void Main()
        {
            string reversedChars = String.Empty;

            for (int i = 0; i < 3; i++)
            {
                char character = char.Parse(Console.ReadLine());
                reversedChars += character;
            }

            for (int i = 2; i >= 0; i--)
            {
                Console.Write(reversedChars[i]);
            }
            Console.WriteLine();
        }
    }
}
