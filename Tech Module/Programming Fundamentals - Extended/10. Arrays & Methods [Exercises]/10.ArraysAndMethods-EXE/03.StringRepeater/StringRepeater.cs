using System;

namespace _03.StringRepeater
{
    class StringRepeater
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int repeatTimes = int.Parse(Console.ReadLine());

            string repeatedString = RepeatString(input, repeatTimes);
            Console.WriteLine(repeatedString);
        }

        static string RepeatString(string str, int timesToRepeat)
        {
            string repeatedString = String.Empty;

            for (int times = 1; times <= timesToRepeat; times++)
            {
                repeatedString += str;
            }
            return repeatedString;
        }
    }
}
