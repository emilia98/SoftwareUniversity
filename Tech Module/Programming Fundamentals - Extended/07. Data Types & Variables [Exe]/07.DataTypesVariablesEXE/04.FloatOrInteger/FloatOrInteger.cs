using System;

namespace _04.FloatOrInteger
{
    class FloatOrInteger
    {
        static void Main()
        {
            var str = Console.ReadLine();

            float floatNum;
            bool isFloat = float.TryParse(str, out floatNum);
            int integerNum;
            bool isInteger = int.TryParse(str, out integerNum);

            if(isFloat)
            {
                Console.WriteLine(Math.Round(floatNum));
            }           
            else if(isInteger)
            {
                Console.WriteLine(integerNum);
            }
        }
    }
}
