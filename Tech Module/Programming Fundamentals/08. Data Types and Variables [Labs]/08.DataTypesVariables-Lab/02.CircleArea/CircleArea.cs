using System;

namespace _02.CircleArea
{
    class CircleArea
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = radius * radius * Math.PI;
            Console.WriteLine($"{area:f12}");
        }
    }
}
