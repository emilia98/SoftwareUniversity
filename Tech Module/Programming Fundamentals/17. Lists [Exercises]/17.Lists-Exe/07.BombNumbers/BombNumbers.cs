using System;
using System.Linq;

namespace _07.BombNumbers
{
    class BombNumbers
    {
        static void Main()
        {
            //input:
            var nums = Console.ReadLine().Split(' ').
                                          Select(int.Parse).
                                          ToList();
            var bombParams = Console.ReadLine().Split(' ').
                                                Select(int.Parse).
                                                ToList();
            int bomb = bombParams[0];
            int power = bombParams[1];

            for (int index = 0; index < nums.Count(); index++)
            {
                if (bomb == nums[index])
                {
                    int elementsInLeft = index;
                    int elementsInRight = nums.Count() - index - 1;
                    int removed = 1;

                    if (elementsInLeft > 0)
                    {
                        int startLeft = index - power;
                        int endLeft = power;
                        if (elementsInLeft < power)
                        {                           
                            startLeft = 0;
                            endLeft = elementsInLeft;
                        }
                        removed = index - startLeft;
                        nums.RemoveRange(startLeft, endLeft);
                        index -= removed;
                    }

                    nums.RemoveRange(index, 1);                  
                    removed = 1;

                    index -= removed;
                    if (elementsInRight > 0)
                    {
                        int startRight = index + 1;
                        int endRight = power;
                        if (elementsInRight < power)
                        {
                            startRight = Math.Min(startRight, nums.Count);
                            endRight = Math.Min(elementsInRight, nums.Count);
                        }
                        nums.RemoveRange(startRight, endRight);                       
                    }
                }
            }

            long sum = 0;
            for (int index = 0; index < nums.Count(); index++)
            {
                sum += nums[index];
            }

            Console.WriteLine(sum);
            //goto input;
        }
    
    }
}
