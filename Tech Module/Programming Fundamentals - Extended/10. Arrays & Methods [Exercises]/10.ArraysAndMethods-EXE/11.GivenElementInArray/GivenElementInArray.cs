using System;

namespace _11.GivenElementInArray
{
    class GivenElementInArray
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int givenElement = int.Parse(Console.ReadLine());

            string[] splitInput = input.Split(' ');
            int[] array = new int[splitInput.Length];

            for (int i = 0; i < splitInput.Length; i++)
            {
                array[i] = int.Parse(splitInput[i]);
            }

            int occurrences = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if(array[j] == givenElement)
                {
                    occurrences++;
                }
            }
            Console.WriteLine(occurences);
        }
    }
}
