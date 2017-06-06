using System;

namespace _06.TripleOfLetters
{
    class TripleOfLetters
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int num1 = 0; num1 < n; num1++)
            {
                char let1 = (char)('a' + num1);
                for (int num2 = 0; num2 < n; num2++)
                {
                    char let2 = (char)('a' + num2);
                    for (int num3 = 0; num3 < n; num3++)
                    {
                        char let3 = (char)('a' + num3);
                        Console.WriteLine("{0}{1}{2}", let1, let2, let3);
                    }
                }
            }
        }
    }
}
