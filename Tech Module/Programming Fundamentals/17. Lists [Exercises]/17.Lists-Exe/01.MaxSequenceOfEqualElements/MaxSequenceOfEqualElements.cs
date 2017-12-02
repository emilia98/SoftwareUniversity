using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            //input:
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var maxSequenceOfEqual = new List<int>();
            var currentSeq = new List<int>();

            maxSequenceOfEqual.Add(nums[0]);
            currentSeq.Add(nums[0]);
            int countInSeq = 1;
            int countInMaxSeq = 1;

            for (int index = 1; index < nums.Count; index++)
            {
                if (nums[index] == currentSeq[0])
                {
                    currentSeq.Add(nums[index]);
                    countInSeq++;
                }
                else
                {
                    if (countInSeq > countInMaxSeq)
                    {
                        maxSequenceOfEqual = CheckForMaxSequence(maxSequenceOfEqual, currentSeq, countInSeq);
                    }
                    currentSeq.Clear();
                    currentSeq.Add(nums[index]);
                    countInSeq = 1;
                }
            }

            if (countInSeq > countInMaxSeq)
            {
                maxSequenceOfEqual = CheckForMaxSequence(maxSequenceOfEqual, currentSeq, countInSeq);
            }

            Console.WriteLine(String.Join(" ", maxSequenceOfEqual));
            //goto input;
        }

        static List<int> CheckForMaxSequence(List<int> currentMaxSeq, List<int> currentSeq, int countInSeq)
        {
            int currentCounter = currentSeq.Count;
            int maxSeqCounter = currentMaxSeq.Count;
            var maxSequence = currentMaxSeq.Skip(0).Take(maxSeqCounter).ToList();

            if (currentCounter > maxSeqCounter)
            {
                maxSequence = currentSeq.Skip(0).Take(countInSeq).ToList();
            }
            return maxSequence;
        }   
    }
}
