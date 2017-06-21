using System;

namespace _05.CharRotation
{
    class CharRotation
    {
        static void Main()
        {
            string inputChar = Console.ReadLine();
            string[] inputInt = Console.ReadLine().Split(' ');

            char[] charArray = inputChar.ToCharArray();
            int[] intArray = new int[inputInt.Length];

            string result = String.Empty;

            for (int i = 0; i < inputInt.Length; i++)
            {
                intArray[i] = int.Parse(inputInt[i]);
                char currentChar;
                if (intArray[i] % 2 == 0)
                {
                    currentChar = (char)((int)charArray[i] - intArray[i]);
                }
                else
                {
                    currentChar = (char)((int)charArray[i] + intArray[i]);
                }
                result += currentChar;
            }
            Console.WriteLine(result);
        }
    }
}
