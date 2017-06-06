using System;

namespace _17.PartOfAsciiTable
{
    class PartOfAsciiTable
    {
        static void Main()
        {
            byte intervalStart = byte.Parse(Console.ReadLine());
            byte intervalEnd = byte.Parse(Console.ReadLine());

            for (int i = intervalStart; i <= intervalEnd; i++)
            {
                Console.Write("{0} ",(char)i);
            }
            Console.WriteLine();
        }
    }
}
