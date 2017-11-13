using System;
using System.Linq;

namespace _07.MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main()
        {
            //input:
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] maxSequence = new int[array.Length];
            int[] currentSequence = new int[array.Length];

            maxSequence[0] = array[0];
            currentSequence[0] = array[0];

            int currentSize = 1;
            int maxSeqSize = 1;

            for (int index = 1; index < array.Length; index++)
            {
                if(array[index - 1] < array[index])
                {
                    currentSequence[currentSize] = array[index];
                    currentSize++;
                }
                else
                {
                    if(currentSize > maxSeqSize)
                    {
                        maxSequence = currentSequence.Skip(0).Take(currentSize).ToArray();
                        maxSeqSize = currentSize;
                    }
                    Array.Clear(currentSequence, 0, currentSize);
                    currentSequence[0] = array[index];
                    currentSize = 1;
                }
            }

            if (currentSize > maxSeqSize)
            {
                maxSequence = currentSequence.Skip(0).Take(currentSize).ToArray();
            }

            Console.WriteLine(String.Join(" ", maxSequence));
            //goto input;
        }
    }
}
