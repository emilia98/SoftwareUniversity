using System;
using System.Linq;

namespace _06.ReverseAnArrayOfStrings_3
{
    class ReverseAnArrayOfStrings_3
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            Console.WriteLine(String.Join(" ", array.Reverse()));
        }
    }
}
