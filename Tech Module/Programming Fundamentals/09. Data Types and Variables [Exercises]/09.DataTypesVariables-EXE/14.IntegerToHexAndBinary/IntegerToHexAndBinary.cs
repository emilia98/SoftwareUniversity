using System;

namespace _14.IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main()
        {
            uint decimalNumber = uint.Parse(Console.ReadLine());
            string numberToHex = Convert.ToString(decimalNumber, 16).ToUpper();
            string numberToBinary = Convert.ToString(decimalNumber, 2);

            Console.WriteLine(numberToHex);
            Console.WriteLine(numberToBinary);
        }
    }
}
