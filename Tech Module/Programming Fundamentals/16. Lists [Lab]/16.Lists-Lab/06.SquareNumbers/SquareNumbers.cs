using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SquareNumbers
{
    class SquareNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var squareNumbers = new List<int>();

            //Find Square Numbers and add them into list
            squareNumbers = FindSquareNumbers(numbers);

            //Sort the list with Square Numbers
            squareNumbers = SortList(squareNumbers);

            Console.WriteLine(String.Join(" ", squareNumbers));
        }

        static List<int> FindSquareNumbers(List<int> numbers)
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

        static List<int> SortList(List<int> squareNumbers)
        {
            var sortedList = new List<int>();

            int index = 0;
            int position = 0;

            while(index < squareNumbers.Count())
            {
                int max = int.MinValue;
                
                for(int cnt = 0; cnt < squareNumbers.Count(); cnt++)
                {
                    if(squareNumbers[cnt] > max)
                    {
                        max = squareNumbers[cnt];
                        position = cnt;
                    }
                }
                sortedList.Add(max);
                squareNumbers.RemoveAt(position);
            }
            return sortedList;
        }      
    }
}
