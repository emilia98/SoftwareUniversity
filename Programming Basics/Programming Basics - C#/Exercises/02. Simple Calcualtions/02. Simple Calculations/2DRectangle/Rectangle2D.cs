using System;

namespace _2DRectangle
{
    class Rectangle2D
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double a = Math.Abs(x1 - x2);
            double b = Math.Abs(y1 - y2);

            double area = a * b;
            double perimeter = (a + b)*2;

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
 
        }
    }
}
