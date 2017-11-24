using System;
using System.Linq;

namespace _03.SafeManipulation_2
{
    class SafeManipulation_2
    {
        static void Main()
        {
            //input: 
            var words = Console.ReadLine().Split(' ').ToArray();

            string commandToRun = Console.ReadLine();
            var splitCommand = commandToRun.Split(' ');
            string command = splitCommand[0];

            while (true)
            {
                if (command == "END")
                {
                    break;
                }

                if (command == "Reverse")
                {
                    words = ReverseArray(words);
                }
                else if (command == "Distinct")
                {
                    words = DistinctArray(words);
                }
                else if (command == "Replace")
                {
                    int indexToRemove = int.Parse(splitCommand[1]);
                    string strToRemove = splitCommand[2];

                    if (indexToRemove >= 0 && indexToRemove < words.Length)
                    {
                        words[indexToRemove] = strToRemove;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                commandToRun = Console.ReadLine();
                splitCommand = commandToRun.Split(' ');
                command = splitCommand[0];
            }
            Console.WriteLine(String.Join(", ", words));

            //goto input;
        }

        static string[] ReverseArray(string[] array)
        {
            int size = array.Length;
            var reversedArray = new string[size];

            for (int index = 0; index < size; index++)
            {
                reversedArray[index] = array[size - 1 - index];
            }
            return reversedArray;
        }

        static string[] DistinctArray(string[] array)
        {
            int size = array.Length;
            int cnt = 0;
            var indexesToRemove = new int[size];

            for (int index = 0; index < size - 1; index++)
            {
                string currentElement = array[index];

                for (int innerIndex = index + 1; innerIndex < size; innerIndex++)
                {
                    if (currentElement == array[innerIndex] &&
                        Array.IndexOf(indexesToRemove, innerIndex) == -1)
                    {
                        indexesToRemove[cnt] = innerIndex;
                        cnt++;
                    }
                }
            }

            var distinctedArray = new string[size - cnt];
            distinctedArray[0] = array[0];
            cnt = 1;
            for (int index = 0; index < size; index++)
            {
                if (Array.IndexOf(indexesToRemove, index) == -1)
                {
                    distinctedArray[cnt] = array[index];
                    cnt++;
                }
            }
            distinctedArray = distinctedArray.Skip(0).Take(cnt).ToArray();
            return distinctedArray;
        }
    }
}
