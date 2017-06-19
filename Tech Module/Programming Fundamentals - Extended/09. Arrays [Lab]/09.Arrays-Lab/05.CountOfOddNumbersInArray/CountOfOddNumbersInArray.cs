using System;

namespace _05.CountOfOddNumbersInArray
{
    class CountOfOddNumbersInArray
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

            int counter = 0;
            for (int j = 0; j < array.Length; j++)
            {
                //or if(Math.Abs(array[j]) % 2 == 1)
                if(array[j] % 2 == 1 || array[j] % 2 == -1)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter); 
        }
    }
}
