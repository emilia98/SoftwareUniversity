using System;

namespace _02.MultiplyAnArrayOfDoubles
{
    class MultiplyAnArrayOfDoubles
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());

            string[] splitInput = input.Split(' ');
            double[] array = new double[splitInput.Length];

            for (int i = 0; i < splitInput.Length; i++)
            {
                array[i] = double.Parse(splitInput[i]);
            }

            for (int j = 0; j < splitInput.Length; j++)
            {
                Console.Write("{0} ",array[j] * p);
            }
            Console.WriteLine();
        }
    }
}
