using System;

namespace _06.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            object result = str1 + " " + str2;
            Console.WriteLine(result);
        }
    }
}
