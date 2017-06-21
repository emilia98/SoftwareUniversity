using System;

namespace _02.ElementsEqualIndex_2
{
    class ElementsEqualIndex_2
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            int[] array = new int[splitInput.Length];

            InitializeArray(splitInput, array);
            string elements = GetElementsEqualToTheirIndex(array);
            Console.WriteLine(elements);
        }

        static int InitializeArray(string[] splitInput, int[] array)
        {
            int length = splitInput.Length;

            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(splitInput[i]);
            }
            return array[length-1];
        }

        static string GetElementsEqualToTheirIndex(int[] array)
        {
            string result = String.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == i)
                {
                    result += i + " ";
                }
            }
            return result;
        }
    }
}
