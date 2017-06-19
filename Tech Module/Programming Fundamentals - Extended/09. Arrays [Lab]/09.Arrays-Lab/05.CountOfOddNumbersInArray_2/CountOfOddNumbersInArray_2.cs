using System;

namespace _05.CountOfOddNumbersInArray_2
{
    class CountOfOddNumbersInArray_2
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            int[] array = new int[splitInput.Length];

            InitializeArray(splitInput, array);
            int oddNumbersCounter = CountOddNumbers(array);
            Console.WriteLine(oddNumbersCounter);
        }

        static void InitializeArray(string[] splitInput, int[] array)
        {
            int length = splitInput.Length;
            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(splitInput[i]);
            }
        }

        static int CountOddNumbers(int[] array)
        {
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(Math.Abs(array[i]) % 2 == 1)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
