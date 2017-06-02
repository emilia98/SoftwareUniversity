using System;

namespace SquareArea
{
    class SquareArea
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            int area = a * a;
            Console.Write("Square = ");
            Console.WriteLine(area);
        }
    }
}
