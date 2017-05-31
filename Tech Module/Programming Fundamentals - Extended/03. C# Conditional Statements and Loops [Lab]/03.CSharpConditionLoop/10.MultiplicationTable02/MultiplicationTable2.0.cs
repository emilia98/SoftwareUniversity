using System;

namespace _10.MultiplicationTable02
{
    class Program
    {
        static void Main()
        {
            byte integer = byte.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if(multiplier > 10)
            {
                Console.WriteLine("{0} X {1} = {2}", integer, multiplier, integer * multiplier);
            }
            else
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", integer, i, integer * i);
                }
            }
        }
    }
}
