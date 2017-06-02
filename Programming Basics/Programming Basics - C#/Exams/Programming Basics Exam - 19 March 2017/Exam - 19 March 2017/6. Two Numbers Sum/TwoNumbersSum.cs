using System;

namespace _6.Two_Numbers_Sum
{
    class TwoNumbersSum
    {
        static void Main()
        {
            int intervalStart = int.Parse(Console.ReadLine());
            int intervalEnd = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            int secondNumber = 0;
            bool isThereACombinationWithMagicNumber = false;
            int combinationWithMagicNumber = 0;
            int currentCombination = 0;

            for (int start = intervalStart; start >= intervalEnd; start--)
            {
                for (int end = intervalStart; end >= intervalEnd; end--)
                {
                    //Console.Write("{0} -> {1} ", start,end);
                    combinations++;
                }
            }


            for (int start = intervalStart; start >= intervalEnd; start--)
            {
                for (int end = intervalStart; end >= intervalEnd; end--)
                {
                    currentCombination++;
                    if (start + end == magicNumber)
                    {
                        //Console.WriteLine("YESSSSSSSSSSSSSS");
                        isThereACombinationWithMagicNumber = true;
                        combinationWithMagicNumber = currentCombination;
                        secondNumber = end;
                        break;
                    }

                }
                if (start + secondNumber == magicNumber && isThereACombinationWithMagicNumber)
                {

                    Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", combinationWithMagicNumber, start, secondNumber, magicNumber);
                    break;
                }
            }

            if (isThereACombinationWithMagicNumber == false)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", combinations, magicNumber);
            }
        }
    }
}
