using System;
using System.Linq;

namespace _06.ReverseAnArrayOfStrings_2
{
    class ReverseAnArrayOfStrings_2
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            int n = array.Length;
            string[] reversedArray = new string[n];

            for(int index = n - 1; index >= 0; index--)
            {
                reversedArray[n - index - 1] = array[index];
            }
            Console.WriteLine(String.Join(" ", reversedArray));
        }
    }
}
