using System;

namespace _13.IncreasingSequence_2
{
    class IncreasingSequence_2
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            int[] array = new int[splitInput.Length];

            InitializeArray(splitInput, array);
            string isTheSequenceIncresing = FindIfIsIncreasing(array);
            Console.WriteLine(isTheSequenceIncresing);
        }

        static int InitializeArray(string[] splitInput, int[] array)
        {
            int length = splitInput.Length;

            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(splitInput[i]);
            }
            return array[length - 1];
        }

        static string FindIfIsIncreasing(int[] array)
        {
            bool isIncreasing = true;
            string result = String.Empty;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    isIncreasing = false;
                    break;
                }
            }

            if (isIncreasing)
            {
                result = "Yes";
            }
            else
            {
                result = "No";
            }
            return result;
        }
    }
}
