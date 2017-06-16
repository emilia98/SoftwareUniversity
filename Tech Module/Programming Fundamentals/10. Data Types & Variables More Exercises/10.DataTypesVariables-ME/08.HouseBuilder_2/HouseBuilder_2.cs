using System;

namespace _08.HouseBuilder_2
{
    class HouseBuilder_2
    {
        static void Main()
        {
            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());

            sbyte sByteNum = 0;
            long intNumber = 0;
            
            if(num1 >= 0 && num1 <= 127)
            {
                sByteNum = (sbyte)num1;
                intNumber = num2;
            }
            else if(num1 >= 128 && num1 <= int.MaxValue)
            {
                sByteNum = (sbyte)num2;
                intNumber = num1;
            }
            long totalPrice = sByteNum * 4 + intNumber * 10;
            Console.WriteLine(totalPrice);
        }
    }
}
