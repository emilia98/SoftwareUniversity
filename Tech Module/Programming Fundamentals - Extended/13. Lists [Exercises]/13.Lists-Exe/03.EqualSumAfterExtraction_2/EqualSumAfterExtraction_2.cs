using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.EqualSumAfterExtraction_2
{
    class EqualSumAfterExtraction_2
    {
        static List<int> list1 = new List<int>();
        static List<int> list2 = new List<int>();

        static void Main()
        {
            list1 = GetANewList(list1);
            list2 = GetANewList(list2);

            list2 = ExtractSecondList(list1, list2);
            string result = GetAResult(list1, list2);
            Console.WriteLine(result);
        }

        static List<int> GetANewList(List<int> list)
        {
            list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            return list;
        }

        static List<int> ExtractSecondList(List<int> list1, List<int> list2)
        {
            for (int pos1 = 0; pos1 < list1.Count; pos1++)
            {
                for (int pos2 = 0; pos2 < list2.Count; pos2++)
                {
                    if(list1[pos1] == list2[pos2])
                    {
                        int currentNumber = list2[pos2];
                        list2.RemoveAll(item => item == currentNumber);
                        break;
                    }
                }
            }
            return list2;
        }

        static string GetAResult(List<int> list1, List<int> list2)
        {
            string result = String.Empty;
            int sumList1 = CalculateSum(list1);
            int sumList2 = CalculateSum(list2);

            if(sumList1 == sumList2)
            {
                result = $"Yes. Sum: {sumList1}";
            }
            else
            {
                result = $"No. Diff: {Math.Abs(sumList1 - sumList2)}";
            }
            return result;
        }

        static int CalculateSum(List<int> list)
        {
            int sum = 0;
            for (int position = 0; position < list.Count; position++)
            {
                sum += list[position];
            }
            return sum;
        }
    }
}
