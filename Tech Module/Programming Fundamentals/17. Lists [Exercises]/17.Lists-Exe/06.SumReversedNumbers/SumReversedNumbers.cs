using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main()
        {
            //input:
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            double sum = 0;

            foreach (var num in nums)
            {
                var reversedDigits = FindAndReverseDigits(num);
                double reversedNumber = double.Parse(String.Join("", reversedDigits));               
                sum += reversedNumber;
            }
            Console.WriteLine(sum);
            //goto input;
        }

        static List<char> FindAndReverseDigits(double num)
        {
            var numAsString = num.ToString();
            var digits = numAsString.ToList();          
            var reversedDigits = new List<char>();
            
            for (int index = digits.Count - 1; index >= 0; index--)
            {
                reversedDigits.Add(digits[index]);
            }
            return reversedDigits;
        }
    }
}
