using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string currentString = Console.ReadLine();

            while(currentString != "end")
            {
                int index = int.Parse(currentString[0].ToString());
                int currentNumber = int.Parse(currentString);
                numbers.Insert(index,currentNumber);
                currentString = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
