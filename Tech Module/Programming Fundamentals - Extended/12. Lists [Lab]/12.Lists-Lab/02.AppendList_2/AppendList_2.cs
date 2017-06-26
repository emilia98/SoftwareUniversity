using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AppendList_2
{
    class AppendList_2
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] delimiter = new char[] {'|'};
            List<string> splitInput = new List<string>();
            List<int> result = new List<int>();

            splitInput = GetNewList(input, delimiter);
            ReverseList(splitInput);       
            result = GetAResult(splitInput ,result);
            Console.WriteLine(String.Join(" ",result));
        }

        static List<string> GetNewList(string input,char[] delimiter)
        {
            List<string> splitInput = input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries).
                                                        ToList();
            return splitInput;
        }

        static List<string> ReverseList(List<string> splitInput)
        {
            splitInput.Reverse();
            return splitInput;
        }

        static List<int> GetAResult(List<string> splitInput, List<int> result)
        {
            for (int i = 0; i < splitInput.Count; i++)
            {
                List<string> currentList = new List<string>();
                currentList = splitInput[i].Split(' ').ToList();

                result = CheckEachPartOfList(currentList, result);
            }
            return result;
        }

        static List<int> CheckEachPartOfList(List<string> currentList, List<int> result)
        {
            for (int j = 0; j < currentList.Count; j++)
            {
                int number;
                bool canConvert = int.TryParse(currentList[j], out number);

                if (canConvert)
                {
                    result.Add(number);
                }
            }
            return result;
        }
    }
}
