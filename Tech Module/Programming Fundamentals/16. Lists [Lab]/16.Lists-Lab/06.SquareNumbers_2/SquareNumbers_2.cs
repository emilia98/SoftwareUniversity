using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SquareNumbers_2
{
    class SquareNumbers_2
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squareNumbers = new List<int>();
          
            //Find Square Numbers and add them into list
            squareNumbers = FindSquareNumbers(numbers);

            //Sort the list with Square Numbers
            squareNumbers.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(String.Join(" ", squareNumbers));
         }

        static List<int> FindSquareNumbers(List < int > numbers)
        {
            var squareNumbers = new List<int>();

            foreach (var number in numbers)
            {
                double squareRootOfNumber = Math.Sqrt(number);

                if (squareRootOfNumber == (int)squareRootOfNumber)
                {
                    squareNumbers.Add(number);
                }
            }       
            return squareNumbers;
        }      
    }
}
