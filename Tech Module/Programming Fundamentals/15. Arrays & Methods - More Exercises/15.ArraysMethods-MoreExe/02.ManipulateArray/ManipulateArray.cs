using System;
using System.Linq;

namespace _02.ManipulateArray
{
    class ManipulateArray
    {
        static void Main()
        {
            //input:
            var words = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int index = 1; index <= n; index++)
            {
                string command = Console.ReadLine();

                if (command == "Reverse")
                {
                    words = ReverseArray(words);
                }
                else if (command == "Distinct")
                {
                    words = DistinctElements(words);
                }
                else
                {
                    string[] splitCommand = command.Split(' ');
                    int indextoReplace = int.Parse(splitCommand[1]);
                    string strToReplace = splitCommand[2];

                    words[indextoReplace] = strToReplace;
                }
            }
            Console.WriteLine(String.Join(", ", words));

            //goto input;
        }

        static string[] ReverseArray(string[] array)
        {
            int size = array.Length;
            var reversedArray = new string[size];

            for (var index = size - 1; index >= 0; index--)
            {
                reversedArray[size - 1 - index] = array[index];
            }
            return reversedArray;
        }

        static string[] DistinctElements(string[] array)
        {
            int size = array.Length;
            var indexesToUse = new int[size - 1];
            int cnt = 0;

            for (int outerIndex = 0; outerIndex < size - 1; outerIndex++)
            {
                for (int innerIndex = outerIndex + 1; innerIndex < size; innerIndex++)
                {
                    if (array[innerIndex] == array[outerIndex])
                    {
                        if (Array.IndexOf(indexesToUse, innerIndex) == -1)
                        {
                            indexesToUse[cnt] = innerIndex;
                            cnt++;
                        }
                    }
                }
            }
            indexesToUse = indexesToUse.Skip(0).Take(cnt).ToArray();

            string[] distinctedArray = new string[size];
            int countAddedElements = 0;

            for (int index = 0; index < size; index++)
            {
                if (Array.IndexOf(indexesToUse, index) == -1)
                {
                    distinctedArray[countAddedElements] = array[index];
                    countAddedElements++;
                }
            }
            distinctedArray = distinctedArray.Skip(0).Take(countAddedElements).ToArray();
            return distinctedArray;
        }
    }
}
