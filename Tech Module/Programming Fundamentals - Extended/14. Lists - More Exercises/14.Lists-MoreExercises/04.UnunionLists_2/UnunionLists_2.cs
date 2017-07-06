using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.UnunionLists_2
{
    class UnunionLists_2
    {
        static void Main()
        {
            List<int> primalList = new List<int>();
            primalList = GetANewList(primalList);
            int n = int.Parse(Console.ReadLine());

            primalList = ChangeThePrimalList(primalList, n);
            Console.WriteLine(String.Join(" ", primalList));
        }

        static List<int> GetANewList(List<int> list)
        {
            list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            return list;
        }

        static List<int> ChangeThePrimalList(List<int> primalList, int n)
        {
            for (int i = 0; i < n; i++)
            {
                List<int> currentList = new List<int>();
                currentList = GetANewList(currentList);

                for (int currentListPosition = 0; currentListPosition < currentList.Count; currentListPosition++)
                {
                    int currentElement = currentList[currentListPosition];
                    bool isThereThisElement = false;

                    for (int primalListPosition = 0; primalListPosition < primalList.Count; primalListPosition++)
                    {
                        if(currentElement == primalList[primalListPosition])
                        {
                            primalList.RemoveAll(item => item == currentElement);
                            primalListPosition--;
                            isThereThisElement = true;
                        }
                    }

                    if(isThereThisElement == false)
                    {
                        primalList.Add(currentElement);
                    }
                }
            }
            primalList.Sort();
            return primalList;
        }
    }
}
