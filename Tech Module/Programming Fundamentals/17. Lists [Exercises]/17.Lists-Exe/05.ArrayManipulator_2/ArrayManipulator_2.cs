//It's correct, but returns Memory And Time Limit on the last Test
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ArrayManipulator_2
{
    class ArrayManipulator_2
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
                    nums = AddElement(nums, index, element);
                }
                else if (splitCommand[0] == "addMany")
                {
                    int index = int.Parse(splitCommand[1]);
                    var elements = splitCommand.Skip(2).
                                                Take(splitCommand.Length).
                                                Select(int.Parse).ToList();

                    nums = AddManyElements(nums, index, elements);
                }
                else if (splitCommand[0] == "contains")
                {
                    int element = int.Parse(splitCommand[1]);
                    Console.WriteLine(IsContained(nums, element));
                }
                else if (splitCommand[0] == "remove")
                {
                    int index = int.Parse(splitCommand[1]);
                    nums = RemoveElement(nums, index);
                }
                else if (splitCommand[0] == "shift")
                {
                    int count = nums.Count;
                    int positions = int.Parse(splitCommand[1]);
                    positions = positions % count;
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


        static List<int> AddElement(List<int> nums, int index, int element)
        {
            var newList = new List<int>();

            for (int cnt = 0; cnt < index; cnt++)
            {
                newList.Add(nums[cnt]);
            }

            newList.Add(element);

            for (int cnt = index; cnt < nums.Count(); cnt++)
            {
                newList.Add(nums[cnt]);
            }

            return newList;
        }

        static List<int> AddManyElements(List<int> nums, int index, List<int> elements)
        {
            var newList = new List<int>();

            for (int cnt = 0; cnt < index; cnt++)
            {
                newList.Add(nums[cnt]);
            }

            foreach (var element in elements)
            {
                newList.Add(element);
            }

            for (int cnt = index; cnt < nums.Count(); cnt++)
            {
                newList.Add(nums[cnt]);
            }

            return newList;
        }

        static List<int> RemoveElement(List<int> nums, int index)
        {
            var newList = new List<int>();

            for (int cnt = 0; cnt < index; cnt++)
            {
                newList.Add(nums[cnt]);
            }

            for (int cnt = index + 1; cnt < nums.Count(); cnt++)
            {
                newList.Add(nums[cnt]);
            }

            return newList;
        }

        static int IsContained(List<int> nums, int element)
        {
            for (int index = 0; index < nums.Count(); index++)
            {
                if (element == nums[index])
                {
                    return index;
                }
            }
            return -1;
        }

        static List<int> ShiftElements(List<int> nums, int pos)
        {
            var shiftedList = nums.Skip(0).Take(nums.Count).ToList();

            for (int cnt = 1; cnt <= pos; cnt++)
            {
                int element = shiftedList[0];
                shiftedList.RemoveAt(0);
                shiftedList.Add(element);
            }
            return shiftedList;
        }

        static List<int> SumPairs(List<int> nums)
        {
            int count = nums.Count;
            var summedNums = new List<int>();
            if (count % 2 == 1)
            {
                nums.Add(0);
            }

            for (int index = 0; index < count; index += 2)
            {
                summedNums.Add(nums[index] + nums[index + 1]);
            }
            return summedNums;
        }
    }
}
