using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DecodeRadioFreqs
{
    class DecodeRadioFreqs
    {
        static void Main()
        {
            decimal[] frequencies = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            List<char> result = new List<char>();
            DecodeFrequencies(frequencies, result);         
            Console.WriteLine(String.Join("", result));
        }

        static List<char> DecodeFrequencies(decimal[] frequencies, List<char> result)
        {
            for (int i = 0; i < frequencies.Length; i++)
            {
                decimal currentFrequency = frequencies[i];
                int left = (int)currentFrequency;

                int indexOfDecimalPoint = currentFrequency.ToString().IndexOf('.');
                int powerOfTen = currentFrequency.ToString().Length - indexOfDecimalPoint - 1;
                int right = (int)((currentFrequency - left) * (decimal)Math.Pow(10, powerOfTen));

                int indexLeft = i;
                InsertCharacters(indexLeft, left, result);
                int indexRight = i + 1;
                InsertCharacters(indexRight, right, result);
                /*int indexLeft = i;
                if (left != 0)
                {
                    char leftChar = (char)left;
                    result.Insert(indexLeft, leftChar);
                }

                int indexRight = i + 1;
                if (right != 0)
                {
                    char rightChar = (char)right;
                    result.Insert(indexRight, rightChar);
                }*/
            }
            return result;
        }

        static List<char> InsertCharacters(int index, int partOfFrequency, List<char> result)
        {
            if(partOfFrequency != 0)
            {
                char partOfFrequencyAsChar = (char)(partOfFrequency);
                result.Insert(index, partOfFrequencyAsChar);
            }
            return result;
        }
    }
}
