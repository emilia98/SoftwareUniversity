//WITH VARIABLE
using System;

namespace GreaterNumber2
{
    class GreaterNumber2
    {
        static void Main()
        {
            Console.WriteLine("Enter two integers: ");

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int greater;

            if (number1 >= number2)
            {
                greater = number1;
            }
            else
            {
                greater = number2;
            }

            Console.WriteLine("Greater number: {0}", greater);
        }
    
    }
}
