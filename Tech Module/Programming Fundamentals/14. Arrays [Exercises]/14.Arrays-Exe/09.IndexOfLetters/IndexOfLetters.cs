using System;

namespace _09.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            //input:
            string str = Console.ReadLine().ToLower();

            for (int index = 0; index < str.Length; index++)
            {
                int code = str[index] - 97;
                Console.WriteLine($"{str[index]} -> {code}");
            }
            //goto input;
        }
    }
}
