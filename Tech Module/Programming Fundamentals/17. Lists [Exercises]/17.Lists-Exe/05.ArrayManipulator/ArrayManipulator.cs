using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main()
        {
            //input:
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();          
            string command = Console.ReadLine();

            while (command != "print")
            {
                var splitCommand = command.Split(' ');

                if (splitCommand[0] == "add")
                {
                    int index = int.Parse(splitCommand[1]);
                    int element = int.Parse(splitCommand[2]);
                    nums.Insert(index, element);
                }
                else if (splitCommand[0] == "addMany")
                {
                    int index = int.Parse(splitCommand[1]);
                    var elements = splitCommand.Skip(2).
                                                Take(splitCommand.Length - 1).
                                                Select(int.Parse);
                    foreach (var element in elements)
                    {
                        nums.Insert(index, element);
                        index++;
                    }
                }
                else if (splitCommand[0] == "contains")
                {
                    int element = int.Parse(splitCommand[1]);
                    Console.WriteLine(nums.IndexOf(element));
                }
                else if (splitCommand[0] == "remove")
                {
                    int index = int.Parse(splitCommand[1]);
                    nums.RemoveAt(index);
                }
                else if (splitCommand[0] == "shift")
                {
                    int positions = int.Parse(splitCommand[1]);
                    positions = positions % nums.Count();
                    nums = ShiftElements(nums, positions);
                }
                else if (splitCommand[0] == "sumPairs")
                {
                    nums = SumPairs(nums);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"[{String.Join(", ", nums)}]");
            //goto input;
        }

        static List<int> SumPairs(List<int> nums)
        {
            var summedNums = new List<int>();
            if (nums.Count % 2 == 1)
            {
                nums.Add(0);              
            }

            for (int index = 0; index < nums.Count(); index += 2)
            {
                summedNums.Add(nums[index] + nums[index + 1]);
            }
            return summedNums;
        }

        static List<int> ShiftElements(List<int> nums, int pos)
        {
            var shiftedList = nums.Skip(0).Take(nums.Count()).ToList();           
            for (int cnt = 1; cnt <= pos; cnt++)
            {
                var element = shiftedList[0];
                shiftedList.RemoveAt(0);
                shiftedList.Add(element);
            }
            return shiftedList;
        }
    }
}
