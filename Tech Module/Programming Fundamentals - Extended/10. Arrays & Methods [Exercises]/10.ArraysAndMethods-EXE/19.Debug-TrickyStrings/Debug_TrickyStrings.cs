using System;

namespace _19.Debug_TrickyStrings
{
    class Debug_TrickyStrings
    {
        static void Main()
        {
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());
            
            var result = string.Empty;
            var currentString = string.Empty;

            for (int i = 1; i < numberOfStrings; i++)
            {
                currentString = Console.ReadLine();
                result += currentString + delimiter;
            }

            currentString = Console.ReadLine();
            result += currentString;
            Console.WriteLine(result);
        }
    }
}
