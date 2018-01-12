using System;
using System.Collections.Generic;

namespace _03.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            if(number == 0)
            {
                stack.Push(0);
            }
            else
            {
                while (number > 0)
                {
                    int reminder = number % 2;
                    number /= 2;

                    stack.Push(reminder);
                }
            }

            Console.WriteLine(String.Join("", stack));
        }
    }
}
