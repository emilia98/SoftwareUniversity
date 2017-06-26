using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AppendList
{
    class AppendList
    {
        static void Main()
        {          
            char[] delimiter = new char[] {'|'};            
            List<string> splitInput = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries)
                                                                                    .ToList();
            splitInput.Reverse();

            List<int> result = new List<int>();
            for (int i = 0; i < splitInput.Count; i++)
            {
                List<string> currentList = new List<string>();
                currentList = splitInput[i].Split(' ').ToList();
                
                for (int j = 0; j < currentList.Count; j++)
                {
                    int number;
                    bool canConvert = int.TryParse(currentList[j], out number);

                    if(canConvert)
                    {
                        result.Add(number);
                    }                    
                }
            }
           Console.WriteLine(String.Join(" ", result));
        }
    }
}
