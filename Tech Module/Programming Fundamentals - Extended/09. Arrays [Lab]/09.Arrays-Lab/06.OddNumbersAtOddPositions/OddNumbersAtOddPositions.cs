using System;

namespace _06.OddNumbersAtOddPositions
{
    class OddNumbersAtOddPositions
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            int[] array = new int[splitInput.Length];

            for (int i = 0; i < splitInput.Length; i++)
            {
                array[i] = int.Parse(splitInput[i]);
            }

            for (int j = 0; j < array.Length; j++)
            {
                if(Math.Abs(array[j]) % 2 == 1 && j % 2 == 1)
                {
                    Console.WriteLine($"Index {j} -> {array[j]}");
                }
            }
        }
    }
}
