using System;

namespace _01.Triangle_Area
{
    class TriangleArea
    {
        static void Main()
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            int side = Math.Abs(x3 - x2);
            int height = Math.Abs(y1 - y2);
            double area = (side * height * 1.0) / 2;

            Console.WriteLine(area);
        }
    }
}
