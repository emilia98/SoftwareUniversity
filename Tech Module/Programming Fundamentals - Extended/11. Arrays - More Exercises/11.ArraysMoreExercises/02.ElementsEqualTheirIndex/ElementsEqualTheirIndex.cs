using System;

namespace _02.ElementsEqualTheirIndex
{
    class ElementsEqualTheirIndex
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

            string result = String.Empty;
            for (int j = 0; j < array.Length; j++)
            {
                if(j == array[j])
                {
                    result += j + " ";
                }
            }
            Console.WriteLine(result);
        }
    }
}
