using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.UnunionLists
{
    class UnunionLists
    {
        static void Main()
        {
            List<int> primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            List<int> currentList = new List<int>();
            for (int i = 0; i < n; i++)
            {
                currentList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                            
                for (int currentListPosition = 0; currentListPosition < currentList.Count; currentListPosition++)
                {
                    int elementInCurrentList = currentList[currentListPosition];
                    bool isThereThisElement = false;
                    for (int primalListPosition = 0; primalListPosition < primalList.Count; primalListPosition++)
                    {
                        int elementInPrimalList = primalList[primalListPosition];
                        
                        if (elementInCurrentList == elementInPrimalList)
                        {
                            primalList.RemoveAll(item => item == elementInCurrentList);
                            primalListPosition--;
                            isThereThisElement = true;
                        }                      
                    }

                    if(isThereThisElement == false)
                    {
                        primalList.Add(elementInCurrentList);
                    }                   
                }
            }
            primalList.Sort();

           Console.WriteLine(String.Join(" ", primalList));
        }
    }
}
