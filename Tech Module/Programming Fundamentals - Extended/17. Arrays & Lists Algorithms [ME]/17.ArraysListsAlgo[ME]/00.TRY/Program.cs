namespace _05IncreasingCrisis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IncreasingCrisis
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            var resultList = new List<int>();

            while (num > 0)
            {
                var givenArray = Console.ReadLine().Split().Select(int.Parse).ToList();
                int insertIndex = 0;

                if (resultList.Count == 0)
                {
                    resultList = givenArray;
                }
                else
                {
                    insertIndex = FindInsertIndex(resultList, givenArray);

                    for (int k = 0; k < givenArray.Count; k++)
                    {
                        resultList.Insert(insertIndex + k, givenArray[k]);
                        if (insertIndex + k != resultList.Count - 1)
                        {
                            if (givenArray[k] > resultList[insertIndex + k + 1])
                            {
                                break;
                            }
                        }
                    }
                    CheckIfItsBroken(resultList);
                }

                num--;
            }

            Console.WriteLine(string.Join(" ", resultList));
        }

        public static void CheckIfItsBroken(List<int> resultList)
        {
            for (int i = 0; i < resultList.Count - 1; i++)
            {
                if (resultList[i] > resultList[i + 1])
                {
                    resultList.RemoveRange(i + 1, (resultList.Count - (i + 1)));
                }
            }
        }

        public static int FindInsertIndex(List<int> resultList, List<int> givenArray)
        {
            int insertIndex = 0;
            for (int i = resultList.Count - 1; i >= 0; i--)
            {
                if (resultList[i] <= givenArray[0])
                {
                    insertIndex = i + 1;
                    break;
                }
            }
            return insertIndex;
        }
    }
}