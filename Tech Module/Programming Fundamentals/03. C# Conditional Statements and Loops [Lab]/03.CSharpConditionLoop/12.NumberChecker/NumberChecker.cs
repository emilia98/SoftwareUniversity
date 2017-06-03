using System;

namespace _12.NumberChecker
{
    class NumberChecker
    {
        static void Main()
        {
            string number = Console.ReadLine();

            try
            {
                Int32.Parse(number);
                Console.WriteLine("It is a number.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
