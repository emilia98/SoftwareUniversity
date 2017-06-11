using System;

namespace _16.TrickyStrings
{
    class TrickyStrings
    {
        static void Main()
        {
            string delimiter = Console.ReadLine();
            uint n = uint.Parse(Console.ReadLine());
            string result = string.Empty;

            for (uint i = 1; i <= n; i++)
            {
                string inputString = Console.ReadLine();

                if (i != n)
                {
                    result += inputString + delimiter;
                }
                else
                {
                    result += inputString;
                }
            }
            Console.WriteLine(result);
        }
    }
}
