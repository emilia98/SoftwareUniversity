using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.IntegerInsertion_2
{
    class IntegerInsertion_2
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            numbers = GetANewList(numbers);
            numbers = GetAModifiedList(numbers);
            Console.WriteLine(String.Join(" ", numbers));
        }

        static List<int> GetANewList(List<int> list)
        {
            list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            return list;
        }

        static List<int> GetAModifiedList(List<int> numbers)
        {
            string currentString = Console.ReadLine();
            while(currentString != "end")
            {
                int index = int.Parse(currentString[0].ToString());
                int currentNumber = int.Parse(currentString);
                numbers.Insert(index, currentNumber);
                currentString = Console.ReadLine();
            }
            return numbers;
        }
    }
}
