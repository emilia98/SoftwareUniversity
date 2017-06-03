using System;

namespace _09.MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main()
        {
            byte integer = byte.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", integer, i, integer * i);
            }
        }
    }
}
