using System;
using System.Collections.Generic;

namespace _03.DecimalToBinary_2
{
    class DecimalToBinary_2
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            if(number == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while(number > 0)
            {
                int reminder = number % 2;
                number /= 2;

                stack.Push(reminder);
            }

            while(stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}
