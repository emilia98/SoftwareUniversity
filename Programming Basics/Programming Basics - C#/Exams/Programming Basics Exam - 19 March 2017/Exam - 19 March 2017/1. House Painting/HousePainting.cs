using System;

namespace _1.House_Painting
{
    class HousePainting
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double frontWallArea = x * x - 1.2 * 2;
            double backWallArea = x * x;
            double sideWallArea = x * y - 1.5 * 1.5;
            double wallsArea = frontWallArea + backWallArea + sideWallArea * 2;

            double roofRectangleArea = x * y;
            double roofTriangleArea = x * h / 2;
            double roofArea = roofRectangleArea * 2 + roofTriangleArea * 2;

            double greenPaintNeeded = wallsArea / 3.4;
            double redPaintNeeded = roofArea / 4.3;

            Console.WriteLine("{0:f2}", greenPaintNeeded);
            Console.WriteLine("{0:0.00}", redPaintNeeded);
        }
    }
}
