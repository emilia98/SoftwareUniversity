using System;
using System.Collections.Generic;

namespace _01.ReverseStrings
{
    class ReverseStrings
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var stack = new Stack<char>();

            for (int index = 0; index < input.Length; index++)
            {
                stack.Push(input[index]);
            }

            while(stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}
