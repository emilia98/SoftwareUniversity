using System;

namespace _12.FromHexToDecValue
{
    class FromHexToDecValue
    {
        static void Main()
        {
            string numberInHex = Console.ReadLine();
            int numberInDecimal = Convert.ToInt32(numberInHex, 16);
            Console.WriteLine(numberInDecimal);
        }
    }
}
