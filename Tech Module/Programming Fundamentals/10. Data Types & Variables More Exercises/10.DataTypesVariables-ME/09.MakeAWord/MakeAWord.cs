using System;

namespace _09.MakeAWord
{
    class MakeAWord
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string word = String.Empty;

            for (int i = 1; i <= n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                word += ch;
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}
