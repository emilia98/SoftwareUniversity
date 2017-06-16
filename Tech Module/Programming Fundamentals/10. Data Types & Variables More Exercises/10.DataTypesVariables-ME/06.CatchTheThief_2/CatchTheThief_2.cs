using System;

namespace _06.CatchTheThief_2
{
    class CatchTheThief_2
    {
        static void Main()
        {
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            decimal typeMaxValue;

            if (type == "sbyte")
            {
                typeMaxValue = sbyte.MaxValue;
            }
            else if (type == "int")
            {
                typeMaxValue = int.MaxValue;
            }
            else
            {
                typeMaxValue = long.MaxValue;
            }

            long currentNumber = long.Parse(Console.ReadLine());
            long closestNumber = currentNumber;

            for (int i = 2; i <= n; i++)
            {
                currentNumber = long.Parse(Console.ReadLine());

                if (Math.Abs(typeMaxValue - currentNumber) < Math.Abs(typeMaxValue - closestNumber) && (typeMaxValue >= currentNumber))
                {
                    closestNumber = currentNumber;
                }
            }
            Console.WriteLine(closestNumber);
        }
    }
}
