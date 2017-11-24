using System;
using System.Linq;

namespace _04.GrabAndGo
{
    class GrabAndGo
    {
        static void Main()
        {
            //input:
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            int lastIndex = FindLastOccurrence(array, num);
           
            if (lastIndex == -1)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                long sum = 0;

                for (int index = 0; index < lastIndex; index++)
                {
                    sum += array[index];
                }

                Console.WriteLine(sum);
            }
            //goto input;
        }

        static int FindLastOccurrence(int[] array, int num)
        {
            int lastIndex = -1;

            for (int index = 0; index < array.Length; index++)
            {
                if(array[index] == num)
                {
                    lastIndex = index;
                }
            }
            return lastIndex;
        }
    }
}
