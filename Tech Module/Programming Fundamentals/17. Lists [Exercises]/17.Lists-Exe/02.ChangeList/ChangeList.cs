using System;
using System.Linq;

namespace _02.ChangeList
{
    class ChangeList
    {
        static void Main()
        {
            //input:
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (true)
            {
                if (command == "Odd")
                {
                    nums = nums.Where(num => num % 2 == 1).ToList();
                    Console.WriteLine(String.Join(" ", nums));             
                    break;
                }
                if (command == "Even")
                {
                    nums = nums.Where(num => num % 2 == 0).ToList();
                    Console.WriteLine(String.Join(" ", nums));                   
                    break;
                }

                var splitCommand = command.Split(' ');

                if (splitCommand[0] == "Delete")
                {
                    int element = int.Parse(splitCommand[1]);

                    for (int index = 0; index < nums.Count(); index++)
                    {
                        if (element == nums[index])
                        {
                            nums.RemoveAt(index);
                            index--;
                        }
                    }
                }
                else if (splitCommand[0] == "Insert")
                {
                    int element = int.Parse(splitCommand[1]);
                    int position = int.Parse(splitCommand[2]);

                    nums.Insert(position, element);
                }                
                command = Console.ReadLine();
            }
            //goto input;
        }
    }
}
