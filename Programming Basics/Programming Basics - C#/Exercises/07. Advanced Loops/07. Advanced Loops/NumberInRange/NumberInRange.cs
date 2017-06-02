using System;

namespace NumberInRange
{
    class NumberInRange
    {
        static void Main()
        {
            int number;
            bool isValid = true;

            while(isValid)
            {
                Console.Write("Enter a number in range [1...10]: ");
                number = int.Parse(Console.ReadLine());
                if(number < 1 || number > 100)
                {
                    Console.WriteLine("Invalid number!");
                }
                else
                {
                    Console.WriteLine("The number is: {0}", number);
                    break;
                }
            }
            
        }
    }
}
