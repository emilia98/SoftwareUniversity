// Vencislav Ivanov's Solution
using System;
using System.Linq;

namespace _03.GroupNumbers_4
{
    class GroupNumbers_4
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(new string[] { ", " },
                                            StringSplitOptions.RemoveEmptyEntries)
                                           .Select(int.Parse)
                                           .ToArray();

            int[] sizes = new int[3];

            foreach (var number in numbers)
            {
                int reminder = Math.Abs(number % 3);
                sizes[reminder]++;
            }

            int[][] matrix = new int[3][]
            {
                new int[sizes[0]],
                new int[sizes[1]],
                new int[sizes[2]],
            };

            int[] offsets = new int[3];

            foreach (var number in numbers)
            { 
                int reminder = Math.Abs(number % 3);
                int index = offsets[reminder];
                offsets[reminder]++;
                matrix[reminder][index] = number;
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
