using System;
using System.Linq;

namespace _09.ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] middleElements = new int[3];

            int size = numbers.Length;

            if(size == 1)
            {
                Console.WriteLine("{ " + $"{numbers[0]}" + " }");
            }
            else if(size % 2 == 0)
            {
                int num1 = numbers[(size / 2) - 1];
                int num2 = numbers[size / 2];
                Console.WriteLine("{ " + $"{num1}, " + $"{num2}" + " }");
            }
            else
            {
                int num1 = numbers[(size / 2) - 1];
                int num2 = numbers[size / 2];
                int num3 = numbers[(size / 2) + 1];
                Console.WriteLine("{ " + $"{num1}, " + $"{num2}, " + $"{num3}" + " }");
            }          
        }
    }
}
