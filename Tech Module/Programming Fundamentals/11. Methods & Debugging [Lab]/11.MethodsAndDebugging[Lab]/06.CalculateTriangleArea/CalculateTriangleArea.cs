using System;

namespace _06.CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main()
        {
            double width = Double.Parse(Console.ReadLine());
            double height = Double.Parse(Console.ReadLine());
            double area = GetATriangleArea(width, height);
            Console.WriteLine(area);
        }

        static double GetATriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
