using System;
using System.Linq;

namespace _04.TripleSum
{
    class TripleSum
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool hasPrinted = false;

            for(int index1 = 0; index1 < numbers.Length; index1++)
            {
                int num1 = numbers[index1];
                for(int index2 = index1 + 1; index2 < numbers.Length; index2++)
                {
                    int num2 = numbers[index2];
                    int sum = num1 + num2;

                    if(FindIfExists(numbers, sum))
                    {
                        hasPrinted = true;
                        Console.WriteLine("{0} + {1} == {2}", num1, num2, sum);
                    }
                }
            }

            if(hasPrinted == false)
            {
                Console.WriteLine("No");
            }
        }

        static bool FindIfExists(int[] numbers, int sum)
        {
            foreach(int number in numbers)
            {
                if(sum == number)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
