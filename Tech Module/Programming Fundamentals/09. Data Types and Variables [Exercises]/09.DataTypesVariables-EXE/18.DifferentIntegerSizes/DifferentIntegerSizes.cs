using System;

namespace _18.DifferentIntegerSizes
{
    class DifferentIntegerSizes
    {
        static void Main()
        {
            string n = Console.ReadLine();
            uint combination = 0;
            string result = String.Empty;

            sbyte numberSByte;
            bool isSByte = sbyte.TryParse(n, out numberSByte);
            if (isSByte)
            {
                combination++;
                result += "* sbyte\n";
            }

            byte numberByte;
            bool isByte = byte.TryParse(n, out numberByte);
            if (isByte)
            {
                combination++;
                result += "* byte\n";
            }

            short numberShort;
            bool isShort = short.TryParse(n, out numberShort);
            if (isShort)
            {
                combination++;
                result += "* short\n";
            }

            ushort numberUShort;
            bool isUShort = ushort.TryParse(n, out numberUShort);
            if (isUShort)
            {
                combination++;
                result += "* ushort\n";
            }

            int numberInt;
            bool isInt = int.TryParse(n, out numberInt);
            if (isInt)
            {
                combination++;
                result += "* int\n";
            }

            uint numberUInt;
            bool isUInt = uint.TryParse(n, out numberUInt);
            if (isUInt)
            {
                combination++;
                result += "* uint\n";
            }

            long numberLong;
            bool isLong = long.TryParse(n, out numberLong);
            if (isLong)
            {
                combination++;
                result += "* long\n";
            }

            if (combination == 0)
            {
                Console.WriteLine("{0} can't fit in any type", n);
            }
            else{
                Console.WriteLine("{0} can fit in:", n);
                Console.WriteLine(result);
            }

        }
    }
}
