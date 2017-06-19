using System;

namespace _14.EqualSequence
{
    class EqualSequence
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

            bool areEqual = true;
            for (int j = 0; j < array.Length - 1; j++)
            {
                if(array[j] != array[j + 1])
                {
                    areEqual = false;
                    break;
                }
            }

            if(areEqual)
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
