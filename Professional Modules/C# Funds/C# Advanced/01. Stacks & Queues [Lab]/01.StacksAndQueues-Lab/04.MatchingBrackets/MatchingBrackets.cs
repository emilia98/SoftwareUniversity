using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class MatchingBrackets
    {
        static void Main()
        {
            string expression = Console.ReadLine();
            var stack = new Stack<int>(); //-> we're going to save here the starting indexes of our subexpressions

            for (int index = 0; index < expression.Length; index++)
            {
                if (expression[index] == '(')
                {
                    stack.Push(index);
                    continue;
                }

                if (expression[index] == ')')
                {
                    int startIndex = stack.Pop();
                    string subExpression = expression.Substring(startIndex, index - startIndex + 1);
                    Console.WriteLine(subExpression);
                }
            }
        }
    }
}
