using System;
using System.Linq;


namespace _01.ArrayContainsElement
{
    class ArrayContainsElement
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int givenElement = int.Parse(Console.ReadLine());

            bool hasFound = SearchForAnElement(numbers, givenElement); 

            if(hasFound)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }

        static bool SearchForAnElement(int[] numbers, int givenElement)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] == givenElement)
                {
                    return true;
                }
            }
            return false;
        }
       
    }
}
