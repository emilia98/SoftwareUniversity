using System;

namespace _02.CirclePerimeter
{
    class CirclePerimeter
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * radius * Math.PI;
            Console.WriteLine("{0:f12}", perimeter);
        }
    }
}
