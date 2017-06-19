using System;

namespace _04.RotateArrayOfStrings
{
    class RotateArrayOfStrings
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');

            string[] rotated = new string[splitInput.Length];
            rotated[0] = splitInput[splitInput.Length - 1];

            for (int i = 0; i < splitInput.Length - 1; i++)
            {
                rotated[i + 1] = splitInput[i];
            }

            for (int j = 0; j < rotated.Length; j++)
            {
                Console.Write($"{rotated[j]} ");
            }
            Console.WriteLine();
        }
    }
}
