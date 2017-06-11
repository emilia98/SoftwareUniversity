using System;

namespace _14.ASCIIString
{
    class ASCIIString
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string text = String.Empty;

            for (int i = 1; i <= n; i++)
            {
                ushort symbolWithNumber = ushort.Parse(Console.ReadLine());
                char symbol = (char)symbolWithNumber;

                text += symbol;
            }
            Console.WriteLine(text);
        }
    }
}
