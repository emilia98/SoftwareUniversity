using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AppendLists
{
    class AppendList
    {
        static void Main()
        {
            var input = Console.ReadLine().Split('|').ToList();
            var appendedLists = new List<double>();

            for(int index = input.Count() - 1; index >= 0; index--)
            {
                var subList = input[index].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                                        Select(double.Parse).ToList();

                foreach(var element in subList)
                {
                    appendedLists.Add(element);
                }
            }
            Console.WriteLine(String.Join(" ", appendedLists));          
        }
    }
}
