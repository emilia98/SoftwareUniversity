using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SquareNumbers_2
{
    class SquareNumbers_2
    {
        static List<int> numbers = new List<int>();

        static void Main()
        {
            numbers = GetNewList(numbers);
            List<int> squareNumbers = new List<int>();
            squareNumbers = FindSquareNumbers(numbers, squareNumbers);
            SortSquareNumbersInDescendingOrder(squareNumbers);
            string result = String.Join(" ", squareNumbers);
            Console.WriteLine(result);
        }

        static List<int> GetNewList(List<int> numbers)
        {
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            return numbers;
        }

        static List<int> FindSquareNumbers(List<int> numbers, List<int> squareNumbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                if(Math.Sqrt(currentNumber) == (int)Math.Sqrt(currentNumber))
                {
                    squareNumbers.Add(currentNumber);
                }
            }
            return squareNumbers;
        }

        static List<int> SortSquareNumbersInDescendingOrder(List<int> squareNumbers)
        {
            squareNumbers.Sort((a, b) => b.CompareTo(a));
            return squareNumbers;
        }
    }
}
