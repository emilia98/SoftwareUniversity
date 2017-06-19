using System;

namespace _12.CountLargerNumbers
{
    class CountLargerNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double numberToCheck = double.Parse(Console.ReadLine());

            string[] splitInput = input.Split(' ');
            double[] array = new double[splitInput.Length];

            for (int i = 0; i < splitInput.Length; i++)
            {
                array[i] = double.Parse(splitInput[i]);
            }

            int occurrences = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if(array[j] > numberToCheck)
                {
                    occurrences++;
                }
            }
            Console.WriteLine(occurrences);
        }
    }
}
