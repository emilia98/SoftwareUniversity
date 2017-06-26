using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.EqualSumAfterExtraction
{
    class EqualSumAfterExtraction
    {
        static void Main()
        {
            List<int> list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sumList1 = 0, sumList2 = 0;
            List<int> newList = new List<int>();

            for (int i1 = 0; i1 < list1.Count; i1++)
            {
                sumList1 += list1[i1];
                for (int i2 = 0; i2 < list2.Count; i2++)
                {                    
                    if(list1[i1] == list2[i2])
                    {
                        int numberToRemove = list2[i2];
                        list2.RemoveAll(item => item == numberToRemove);
                        break;
                    }                   
                }
            }

            for (int i2 = 0; i2 < list2.Count; i2++)
            {
                sumList2 += list2[i2];
            }
            
            if(sumList1 == sumList2)
            {
                Console.WriteLine("Yes. Sum: {0}", sumList1);
            }
            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(sumList1 - sumList2));
            }

        }
    }
}
