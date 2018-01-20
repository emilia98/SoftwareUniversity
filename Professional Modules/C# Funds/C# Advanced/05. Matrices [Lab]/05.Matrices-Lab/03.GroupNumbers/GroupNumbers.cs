using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GroupNumbers
{
    class GroupNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ', ',' },
                                             StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();

            var remindersData = new Dictionary<int, List<int>>();
            remindersData.Add(0, new List<int>());
            remindersData.Add(1, new List<int>());
            remindersData.Add(2, new List<int>());

            foreach (var number in numbers)
            {
                int reminder = Math.Abs(number % 3);

                if(reminder == 0)
                {
                    remindersData[0].Add(number);
                }
                else if(reminder == 1)
                {
                    remindersData[1].Add(number);
                }
                else
                {
                    remindersData[2].Add(number);
                }
            }

            int[][] matrix = new int[3][];

            for (int index = 0; index < 3; index++)
            {
                matrix[index] = remindersData[index].ToArray();
            }

            foreach (var submatrix in matrix)
            {
                Console.WriteLine(String.Join(" ", submatrix));
            }            
        }
    }
}
