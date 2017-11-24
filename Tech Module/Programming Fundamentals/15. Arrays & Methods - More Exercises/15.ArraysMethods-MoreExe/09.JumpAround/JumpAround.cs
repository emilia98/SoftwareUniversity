using System;
using System.Linq;

namespace _09.JumpAround
{
    class JumpAround
    {
        static void Main()
        {
            //input:
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int size = nums.Length;
            long collectedSum = nums[0];
            int currentIndex = 0;
            bool hasSuccessful = false;

            while (true)
            {
                int positions = nums[currentIndex];

                int index = currentIndex;
                index += positions;

                if (index >= 0 && index < size)
                {
                    collectedSum += nums[index];
                    hasSuccessful = true;
                    currentIndex = index;
                }

                index = currentIndex;
                index -= positions;

                if (index >= 0 && index < size && (!hasSuccessful))
                {
                    collectedSum += nums[index];
                    hasSuccessful = true;
                    currentIndex = index;
                }

                if (!hasSuccessful)
                {
                    break;
                }

                hasSuccessful = false;
            }

            Console.WriteLine(collectedSum);
            //goto input;
        }
    }
}
