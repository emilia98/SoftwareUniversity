using System;
using System.Linq;

namespace _06.SumReversedNumbers_2
{
    class SumReversedNumbers_2
    {
        static void Main()
        {
            //input:
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            double sum = 0;

            foreach (var num in nums)
            {
                string numberAsString = num.ToString();
                double reversedNumber = double.Parse(ReverseString(numberAsString));
                sum += reversedNumber;
            }
            Console.WriteLine(sum);           
            //goto input;
        }

        static string ReverseString(string str)
        {
            string reversedString = "";

            for (int index = str.Length - 1; index >= 0; index--)
            {
                reversedString += str[index];
            }
            return reversedString;
        }
    }
}
