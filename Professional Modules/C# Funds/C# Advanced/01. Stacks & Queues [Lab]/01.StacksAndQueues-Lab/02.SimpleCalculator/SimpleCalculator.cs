using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SimpleCalculator
{
    class SimpleCalculator
    {
        static void Main()
        {
            //input:
            string input = Console.ReadLine();
            var splitInput = input.Split(' ');

            var stack = new Stack<string>(splitInput.Reverse());

            while(stack.Count > 1)
            {
                var firstNumber = double.Parse(stack.Pop());
                var oper = stack.Pop();
                var secondNumber = double.Parse(stack.Pop());

                // By default, the operation is addition
                var result = (firstNumber + secondNumber).ToString();                   
                
                if(oper == "-")
                {
                    result = (firstNumber - secondNumber).ToString();                   
                }

                stack.Push(result);
            }

            Console.WriteLine(stack.Pop());
            //goto input;           
        }
    }
}
