using System;

namespace _08.HouseBuilder
{
    class HouseBuilder
    {
        static void Main()
        {
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            
            sbyte sByteNumber;
            bool isSByte = sbyte.TryParse(number1,out sByteNumber);
            long intNumber;

            if (isSByte)
            {
                intNumber = long.Parse(number2);
            }
            else
            {
                isSByte = sbyte.TryParse(number2, out sByteNumber);
                intNumber = long.Parse(number1);
            }
            long totalPrice = intNumber * 10 + sByteNumber * 4;
            Console.WriteLine(totalPrice);
        }
    }
}
