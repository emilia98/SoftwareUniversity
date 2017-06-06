using System;

namespace _04.VariableHexFormat
{
    class VariableHexFormat
    {
        static void Main()
        {
            string hexNumber = Console.ReadLine();
            int decimalNumber = Convert.ToInt32(hexNumber, 16);

            Console.WriteLine(decimalNumber);
        }
    }
}
