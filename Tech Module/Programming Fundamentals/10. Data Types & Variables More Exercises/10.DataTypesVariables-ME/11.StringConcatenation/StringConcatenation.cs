using System;

namespace _11.StringConcatenation
{
    class StringConcatenation
    {
        static void Main()
        {
            char delimeter = char.Parse(Console.ReadLine());
            string oddOrEven = Console.ReadLine();
            uint n = uint.Parse(Console.ReadLine());

            int reminder;

            if(oddOrEven == "odd")
            {
                reminder = 1;
            }
            else
            {
                reminder = 0;
            }

            string concatString = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string textToConcat = Console.ReadLine();

                if(i % 2 == reminder)
                {
                    if(i == n || i == n - 1)
                    {
                        concatString += textToConcat;
                    }
                    else
                    {
                        concatString += textToConcat + delimeter;
                    }
                }
            }
            Console.WriteLine(concatString);
        }
    }
}
