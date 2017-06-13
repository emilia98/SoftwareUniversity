using System;

namespace _05.TriangleArea
{
    class TriangleArea
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = CalculateTriangleArea(side, height);
            Console.WriteLine(area);
        }

        static double CalculateTriangleArea(double side, double height)
        {
            return side * height / 2;
        }
    }
}
