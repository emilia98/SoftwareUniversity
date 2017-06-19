using System;

namespace _13.IncreasingSequence
{
    class IncreasingSequence
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

            bool isIncreasing = true;
            for (int j = 0; j < array.Length - 1; j++)
            {
                if(array[j] >= array[j + 1])
                {
                    isIncreasing = false;
                    break;
                }
            }
            
            if(isIncreasing)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
