using System;
using System.Linq;

namespace _09.JumpAround_2
{
    class JumpAround_2
    {
        static void Main()
        {
            //input:
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int size = nums.Length;
            int collectedSum = nums[0];
            int currentIndex = 0;
            bool hasSuccessful = false;

            while (true)
            {
                int positions = nums[currentIndex];
                int index = 0;

                int subtractValue = currentIndex - positions;
                int sumValue = currentIndex + positions;

                if (sumValue >= 0 && sumValue < size)
                {
                    hasSuccessful = true;
                    index = sumValue;
                }
                else if (subtractValue >= 0 && subtractValue < size)
                {
                    hasSuccessful = true;
                    index = subtractValue;
                }

                if (hasSuccessful)
                {
                    collectedSum += nums[index];
                    currentIndex = index;
                }
                else
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
