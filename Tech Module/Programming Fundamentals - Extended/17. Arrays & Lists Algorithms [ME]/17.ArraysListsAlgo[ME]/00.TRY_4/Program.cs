using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.TRY_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                List<int> newList = new List<int>();
                newList = GetANewList(newList);

                AddIncreasingElements(newList, i, result);

            }
            Console.WriteLine(String.Join(" ", result));
        }

        static List<int> GetANewList(List<int> newList)
        {
            newList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            return newList;
        }

        static bool CheckIfAllAreIncreasing(List<int> newList)
        {
           // int current = newList[0];
            for (int i = 0; i < newList.Count - 1; i++)
            {
                if (newList[i] > newList[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        static List<int> AddIncreasingElements(List<int> newList, int i, List<int> result)
        {
            if(i == 0)
            {
                /* result.Add(newList[0]);
                 int resultIndex = 0;
                 for (int index = 1; index < newList.Count; index++)
                 {
                     if(newList[index - 1] <= newList[index])
                     {
                         int elementToAdd = newList[index];
                         result.Add(elementToAdd);
                     }
                     else
                     {
                         break;
                     }               
                 }*/
                for (int index = 0; index < newList.Count; index++)
                {
                    result.Add(newList[index]);
                }
                return result;
                //  Console.WriteLine(String.Join(" ", result));
            }
            else
            {
                int elementToInsert = newList[0];
                InsertElement(result, elementToInsert);
                for (int index = 1; index < newList.Count; index++)
                {
                    if(newList[index - 1] <= newList[index])
                    {
                        elementToInsert = newList[index];
                        InsertElement(result, elementToInsert);
                    }
                    else
                    {
                        int lastInserted = elementToInsert;
                        RemoveElements(result, lastInserted);
                        break;
                    }                    
                }
               // Console.WriteLine(String.Join(" ", result));
            }
            return newList;
        }

        static List<int> InsertElement(List<int> result, int elementToInsert)
        {
            bool hasInserted = false;
            for (int index = 0; index < result.Count; index++)
            {
                int currentListElement = result[index];
                if(elementToInsert <= currentListElement)
                {
                    for (int i = 0; i < length; i++)
                    {

                    }
                    result.Insert(index, elementToInsert);
                    hasInserted = true;
                    break;
                }               
            }
            if(!hasInserted)
            {
                result.Add(elementToInsert);
            }
            return result;
        }

        static List<int> RemoveElements(List<int> result, int lastInserted)
        {
            for (int index = 0; index < result.Count; index++)
            {
                int currentListElement = result[index];
                if (lastInserted < currentListElement)
                {
                    result.RemoveAt(index);
                    index--;
                }                
            }
            return result;
        }

        static List<int> InsertElementOfIncreasingSequence(List<int> result, List<int> newList, ref int lastInserted)
        {
            for (int index = 0; index < result.Count; index++)
            {
                int currentListElement = result[index];
                if (newList[0] <= currentListElement)
                {
                    //for (int i = 0; i < newList.Count; i++)
                    //{
                    int i = 0;
                    while (newList[i] <= newList[i + 1])
                    {
                        result.Insert(index, newList[i]);
                        index++;
                        i++;
                    }
                }//
                break;
            }
                }
            }
            return result;
        }
    }
}
