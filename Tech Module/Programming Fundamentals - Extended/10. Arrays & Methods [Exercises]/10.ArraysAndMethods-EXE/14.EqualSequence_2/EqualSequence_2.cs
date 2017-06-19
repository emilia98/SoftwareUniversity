using System;

namespace _14.EqualSequence_2
{
    class EqualSequence_2
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            int[] array = new int[splitInput.Length];

            InitializeArray(splitInput, array);
            string areElementsEqual = FindIfAllAreEqual(array);
            Console.WriteLine(areElementsEqual);
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

        static string FindIfAllAreEqual(int[] array)
        {
            bool areEqual = true;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != array[i + 1])
                {
                    areEqual = false;
                    break;
                }
            }

            string areElementsEqual;
            if(areEqual)
            {
                areElementsEqual = "Yes";
            }
            else
            {
                areElementsEqual = "No";
            }
            return areElementsEqual;
        }
    }
}
