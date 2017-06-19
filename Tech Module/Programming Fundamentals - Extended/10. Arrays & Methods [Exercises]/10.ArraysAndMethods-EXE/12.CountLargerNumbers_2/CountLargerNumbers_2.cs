using System;

namespace _12.CountLargerNumbers_2
{
    class CountLargerNumbers_2
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double numberToCheck = double.Parse(Console.ReadLine());

            string[] splitInput = input.Split(' ');
            double[] array = new double[splitInput.Length];

            InitializeArray(splitInput, array);
            int occurrences = CountOccurrencesOfLargerNumbers(array, numberToCheck);
            Console.WriteLine(occurrences);
        }

        static double InitializeArray(string[] splitInput, double[] array)
        {
            int length = splitInput.Length;

            for (int i = 0; i < length; i++)
            {
                array[i] = double.Parse(splitInput[i]);
            }
            return array[length - 1];
        }

        static int CountOccurrencesOfLargerNumbers(double[] array, double numberToCheck)
        {
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > numberToCheck)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
