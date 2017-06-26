using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StuckZipper
{
    class StuckZipper
    {
        static void Main()
        {
            List<int> list1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int minDigitsList1 = 7;
            List<int> numberDigitsList1 = new List<int>();
            for (int i = 0; i < list1.Count; i++)
            {
                int currentNumber = Math.Abs(list1[i]);
                string currentNumberToString = currentNumber.ToString();
                int digitsCurrentNumber = currentNumberToString.Length;

                if(digitsCurrentNumber < minDigitsList1)
                {
                    minDigitsList1 = digitsCurrentNumber;
                }

                numberDigitsList1.Add(digitsCurrentNumber);
            }

            int minDigitsList2 = 7;
            List<int> numberDigitsList2 = new List<int>();
            for (int i = 0; i < list2.Count; i++)
            {
                int currentNumber = Math.Abs(list2[i]);
                int digitsCurrentNumber = 0;

                while(currentNumber > 0)
                {
                    digitsCurrentNumber++;
                    currentNumber /= 10;
                }
                
                if (digitsCurrentNumber < minDigitsList2)
                {
                    minDigitsList2 = digitsCurrentNumber;
                }

                numberDigitsList2.Add(digitsCurrentNumber);
            }

            int minDigits = Math.Min(minDigitsList1,minDigitsList2);
          
            List<int> newList1 = new List<int>();
            for (int j = 0; j < list1.Count; j++)
            {
                int currentNumber = list1[j];
                if (numberDigitsList1[j] <= minDigits)
                {
                    newList1.Add(currentNumber);
                }
            }

            List<int> newList2 = new List<int>();
            for (int j = 0; j < list2.Count; j++)
            {
                int currentNumber = list2[j];
                if (numberDigitsList2[j] <= minDigits)
                {
                    newList2.Add(currentNumber);
                }
            }

            List<int> zippedList = new List<int>();
            int zippedListCount = newList1.Count + newList2.Count;
            int elementPositionInList1 = 0, elementPositionInList2 = 0;

            for (int pos = 0; pos < zippedListCount; pos++)
            {                
                int elementToZip;
                if(elementPositionInList2 < newList2.Count && elementPositionInList1 < newList1.Count)
                {
                    if (pos % 2 == 0 && elementPositionInList2 < newList2.Count)
                    {
                        elementToZip = newList2[elementPositionInList2];
                        zippedList.Add(elementToZip);
                        elementPositionInList2++;

                    }
                    else if (pos % 2 == 1 && elementPositionInList1 < newList1.Count)
                    {
                        elementToZip = newList1[elementPositionInList1];
                        zippedList.Add(elementToZip);
                        elementPositionInList1++;
                    }                    
                }
                else if(elementPositionInList2 < newList2.Count && elementPositionInList1 >= newList1.Count)
                {
                    elementToZip = newList2[elementPositionInList2];
                    zippedList.Add(elementToZip);
                    elementPositionInList2++;
                }
                else if (elementPositionInList2 >= newList2.Count && elementPositionInList1 < newList1.Count)
                {
                    elementToZip = newList1[elementPositionInList1];
                    zippedList.Add(elementToZip);
                    elementPositionInList1++;
                }
               else
                {
                    break;
                }              
            }          
            Console.WriteLine(String.Join(" ", zippedList));
        }
    }
}
