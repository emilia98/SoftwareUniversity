using System;

namespace _02.RectangleArea
{
    class RectangleArea
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;

            Console.WriteLine($"{area:f2}");
        }
    }
}
