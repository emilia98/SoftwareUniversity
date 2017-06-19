using System;

namespace _02.MultiplyAnArrayOfDoubles_2
{
    class MultiplyAnArrayOfDoubles_2
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            string[] splitInput = input.Split(' ');
            double[] array = new double[splitInput.Length];

            InitializeArray(splitInput,p,array);
            MultiplyArrayElements(p, array);
        }

        static double InitializeArray(string[] splitInput, double p, double[] array)
        {
            for (int i = 0; i < splitInput.Length; i++)
            {
                array[i] = double.Parse(splitInput[i]);
            }
            return array[splitInput.Length - 1];
        }

        static void MultiplyArrayElements(double p, double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= p;
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}
