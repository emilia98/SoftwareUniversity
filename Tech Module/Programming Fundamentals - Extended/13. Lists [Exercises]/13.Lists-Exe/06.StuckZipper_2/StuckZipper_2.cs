using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StuckZipper_2
{
    class StuckZipper_2
    {
        static List<int> list1 = new List<int>();
        static List<int> list2 = new List<int>();

        static void Main()
        {
            list1 = GetANewList(list1);
            list2 = GetANewList(list2);
            List<int> zippedList = GetAResult(list1, list2);
            Console.WriteLine(String.Join(" ", zippedList));
        }

        static List<int> GetANewList(List<int> list)
        {
            list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            return list;
        }

        static List<int> GetAResult(List<int> list1, List<int> list2)
        {
            //Here, we create a list, which will holds count of digits for each element in our
            //original list. We do the same for the second list.
            List<int> numberDigitsList1 = new List<int>();
            numberDigitsList1 = GetMinDigitsFromAList(list1, numberDigitsList1).Item2;
            int minDigitsList1 = GetMinDigitsFromAList(list1, numberDigitsList1).Item1;

            List<int> numberDigitsList2 = new List<int>();
            numberDigitsList2 = GetMinDigitsFromAList(list2, numberDigitsList2).Item2;
            int minDigitsList2 = GetMinDigitsFromAList(list2, numberDigitsList2).Item1;

            //Here, we find the count of min digits, so we could search only for numbers with <= count
            // of digits;
            int minDigits = Math.Min(minDigitsList1, minDigitsList2);

            //Here, we create two new lists, which will hold only the numbers we want to.
            List<int> newList1 = new List<int>();
            GetANewListWithDigitsConstrains(list1, newList1, numberDigitsList1, minDigits);
            List<int> newList2 = new List<int>();
            GetANewListWithDigitsConstrains(list2, newList2, numberDigitsList2, minDigits);

            //Here, we create a list, which will holds the result.
            List<int> zippedList = new List<int>();
            zippedList = CreateAZippedList(newList1, newList2, zippedList);

            return zippedList;
        }

        /*In this method we will check what is the minimum count of digits in both lists -> list1 & list2
          The first value is the number of minimum count of digits.
          The second value is the list, in which we'll hold the count of digits of each element in
          each lists*/
        static Tuple<int, List<int>> GetMinDigitsFromAList(List<int> list, List<int> numberDigitsList)
        {
            //Because the max numbers we could hold is 1000000 -> 7 digits
            int minDigitsList = 7;

            for (int i = 0; i < list.Count; i++)
            {
                int currentNumber = Math.Abs(list[i]);
                string currentNumberToString = currentNumber.ToString();
                int digitsCurrentNumber = currentNumberToString.Length;

                if (digitsCurrentNumber < minDigitsList)
                {
                    minDigitsList = digitsCurrentNumber;
                }

                //Add the count of digits of our current element
                numberDigitsList.Add(digitsCurrentNumber);
            }
            return new Tuple<int, List<int>>(minDigitsList, numberDigitsList);
        }

        // Here, we create a new list as removing all the elements from each of input lists, which
        // has more digits than needed
        static List<int> GetANewListWithDigitsConstrains(List<int> list, List<int> newList,
                                                        List<int> numberDigitsList, int minDigits)
        {          
            for (int i = 0; i < list.Count; i++)
            {
                int currentNumber = list[i];
                if(numberDigitsList[i] <= minDigits)
                {
                    newList.Add(currentNumber);
                }
            }
            return newList;
        }

        //Here, we create the list, which we will print
        static List<int> CreateAZippedList(List<int> newList1, List<int> newList2, List<int> zippedList)
        {
            int zippedListCount = newList1.Count + newList2.Count;
            int elementPositionInList1 = 0, elementPositionInList2 = 0;

            for (int pos = 0; pos < zippedListCount; pos++)
            {
                //If we haven't reached the end of each list
                if (elementPositionInList2 < newList2.Count && elementPositionInList1 < newList1.Count)
                {
                    if (pos % 2 == 0 && elementPositionInList2 < newList2.Count)
                    {
                        zippedList = ZipInList(newList2, zippedList, elementPositionInList2);
                        elementPositionInList2++;
                    }
                    else if (pos % 2 == 1 && elementPositionInList1 < newList1.Count)
                    {
                        zippedList = ZipInList(newList1, zippedList, elementPositionInList1);
                        elementPositionInList1++;
                    }
                }
                //If we have reached the end of the first list, we should continue adding the elements only
                //from the second one.
                else if (elementPositionInList2 < newList2.Count && elementPositionInList1 >= newList1.Count)
                {
                    zippedList = ZipInList(newList2, zippedList, elementPositionInList2);
                    elementPositionInList2++;
                }
                //If we have reached the end of the second list, we should continue adding the elements only
                //from the first one.
                else if (elementPositionInList2 >= newList2.Count && elementPositionInList1 < newList1.Count)
                {
                    zippedList = ZipInList(newList1, zippedList, elementPositionInList1);
                    elementPositionInList1++;
                }
                //If we have reached the end of both lists, we should exit from the loop.
                //Maybe, it's not nesessery to have this case, because we will
                //exit the for-loop nevertheless
                // -> The number of iterations is sum of elements from the both lists.
                else
                {
                    break;
                }
            }
            return zippedList;
        }

        //Here, we add elements to the result list
        static List<int> ZipInList(List<int> newList, List<int> zippedList, int elementPositionInList)
        {
            int elementToZip = newList[elementPositionInList];
            zippedList.Add(elementToZip);
            elementPositionInList++;
            return zippedList;
        }
    }
}
