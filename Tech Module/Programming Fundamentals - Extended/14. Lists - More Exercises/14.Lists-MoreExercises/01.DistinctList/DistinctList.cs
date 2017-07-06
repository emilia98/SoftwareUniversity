using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.DistinctList
{
    class DistinctList
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if(currentNumber == numbers[j])
                    {                                               
                            numbers.RemoveAt(j);
                        j--;                                                  
                    }
                }                
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
