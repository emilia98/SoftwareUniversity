using System;

namespace GreaterNumber
{
    class GreaterNumber1
    {
        static void Main()
        {
            Console.WriteLine("Enter two integers: ");

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (number1 >= number2)
            {
                Console.WriteLine("Greater number: {0}", number1);
            }
            else
            {
                Console.WriteLine("Greater number: {0}", number2);
            }
        }
    }
}
