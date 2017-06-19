using System;

namespace _03.SmallestElementInArray
{
    class SmallestElementInArray
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

            int minValue = array[0];
            //or int minValue = int.MaxValue;
            for (int i = 1; i < array.Length; i++)
            {
                if(array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            Console.WriteLine(minValue);
        }
    }
}
