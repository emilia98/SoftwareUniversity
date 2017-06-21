using System;

namespace _01.Last3ConseqEqualStrings
{
    class Last3ConseqEqualStrings
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] array = input.Split(' ');

            string lastThreeConsequtive = String.Empty;

            for (int i = 0; i < array.Length - 2; i++)
            {
                if(array[i] == array[i + 1] && array[i + 1] == array[i + 2])
                {
                    lastThreeConsequtive = $"{array[i]} {array[i]} {array[i]}";
                }
            }
            Console.WriteLine(lastThreeConsequtive);
        }
    }
}
