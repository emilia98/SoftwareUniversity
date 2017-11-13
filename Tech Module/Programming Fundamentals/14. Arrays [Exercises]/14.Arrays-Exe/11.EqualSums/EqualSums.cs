using System;
using System.Linq;

namespace _11.EqualSums
{
    class EqualSums
    {
        static void Main()
        {
            //input:
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len = array.Length;
            
            if (len <= 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                bool hasFoundSums = false;
                int[] indexes = new int[len];
                int cnt = 0;
                
                for (int index = 0; index < len; index++)
                {
                    long leftSum = 0;
                    for (int innerIndex = 0; innerIndex < index; innerIndex++)
                    {
                        leftSum += array[innerIndex];
                    }

                    long rightSum = 0;
                    for (int innerIndex = index + 1; innerIndex < len; innerIndex++)
                    {
                        rightSum += array[innerIndex];
                    }

                    if (leftSum == rightSum)
                    {
                        hasFoundSums = true;
                        indexes[cnt] = index;
                        cnt++;
                    }
                }

                if (hasFoundSums)
                {
                    indexes = indexes.Skip(0).Take(cnt).ToArray();
                    Console.WriteLine(String.Join(" ", indexes));
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            //goto input;
        }
    }
}
