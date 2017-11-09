using System;
using System.Linq;

namespace _06.ReverseAnArrayOfStrings
{
    class ReverseAnArrayOfStrings
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            int n = array.Length - 1;

            for (int index = 0; index <= n / 2; index++)
            {
                string temp = array[index];
                array[index] = array[n - index];
                array[n - index] = temp;
            }
            Console.WriteLine(String.Join(" ", array));
        }
    }
}
