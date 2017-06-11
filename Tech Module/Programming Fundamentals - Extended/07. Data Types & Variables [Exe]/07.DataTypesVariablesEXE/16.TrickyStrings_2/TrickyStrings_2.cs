using System;

namespace _16.TrickyStrings_2
{
    class TrickyStrings_2
    {
        static void Main()
        {
            string delimiter = Console.ReadLine();
            uint n = uint.Parse(Console.ReadLine());

            string inputString;
            string result = string.Empty;

            for (uint i = 1; i < n; i++)
            {
                inputString = Console.ReadLine();
                result += inputString + delimiter;
            }
            inputString = Console.ReadLine();
            result += inputString;

            Console.WriteLine(result);
        }
    }
}
