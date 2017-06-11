using System;

namespace _07.FromTerabytesToBits
{
    class FromTerabytesToBits
    {
        static void Main()
        {
            double terabytes = double.Parse(Console.ReadLine());
            double bits = terabytes * 1024 * 1024 * 1024 * 1024 * 8;

            Console.WriteLine(bits);
        }
    }
}
