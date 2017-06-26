using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> splitInput = input.Split(' ').ToList();
            List<int> numbers = new List<int>();

            //Here, we parse every emelemt from list-string to list-int
            for (int i = 0; i < splitInput.Count; i++)
            {
                numbers.Add(int.Parse(splitInput[i]));
            }

            int listElements = numbers.Count;
            int[] negative = new int[listElements];
            int cnt = 0;

            //Here, we find every negative element which is in the list with ints and store every value 
            //in an array 
            for (int i = 0; i < listElements; i++)
            { 
                if(numbers[i] < 0)
                {
                    negative[cnt] = numbers[i];
                    cnt++;
                }   
            }

            //Here, we remove all the negative element we've already had in the array, which holds only
            //negative values from the list
            for (int i = 0; i < cnt; i++)
            {
                numbers.RemoveAll(number => number == negative[i]);
            }

            //Here, we checks different conditions before printing the result
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                //Here, we reverse the whole list 
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    Console.Write($"{numbers[i]} ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
