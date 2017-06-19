using System;

namespace _03.SmallestElementInArray_2
{
    class SmallestElementInArray_2
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            int[] array = new int[splitInput.Length];

            InitializeInput(splitInput, array);
            int smallestElement = FindSmallestElement(array);
            Console.WriteLine(smallestElement);
        }

        static int InitializeInput(string[] splitInput, int[] array)
        {
            for (int i = 0; i < splitInput.Length; i++)
            {
                array[i] = int.Parse(splitInput[i]);
            }
            return array[splitInput.Length - 1];
        }

        static int FindSmallestElement(int[] array)
        {
            int smallestElement = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if(array[i] < smallestElement)
                {
                    smallestElement = array[i];
                }
            }
            return smallestElement;
        }
    }
}
