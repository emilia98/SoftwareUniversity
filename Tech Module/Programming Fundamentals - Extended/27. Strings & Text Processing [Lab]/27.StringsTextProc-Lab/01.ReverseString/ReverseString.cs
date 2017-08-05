using System;
using System.Linq;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var reversedInput = input.Reverse();
            Console.WriteLine(String.Join("", reversedInput));          
        }
    }
}
