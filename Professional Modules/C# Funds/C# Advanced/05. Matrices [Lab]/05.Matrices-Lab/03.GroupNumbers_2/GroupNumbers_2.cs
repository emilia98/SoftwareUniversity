using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GroupNumbers_2
{
    class GroupNumbers_2
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ', ',' },
                                            StringSplitOptions.RemoveEmptyEntries)
                                           .Select(int.Parse)
                                           .ToArray();

            var remindersData = new Dictionary<int, int>();

            for (int index = 0; index < numbers.Length; index++)
            {
                int number = numbers[index];
                int reminder = Math.Abs(number % 3);

                remindersData.Add(index, reminder);
            }

            int[][] matrix = new int[3][];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int reminder = row;
                matrix[row] = remindersData.Where(x => x.Value % 3 == reminder)
                                           .Select(x => numbers[x.Key])
                                           .ToArray();
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
