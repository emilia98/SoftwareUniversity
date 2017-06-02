using System;

namespace PointOnRectangleBorder
{
    class PointOnRectangleBorder
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double point_X = double.Parse(Console.ReadLine());
            double point_Y = double.Parse(Console.ReadLine());

            string border = "Border";
            string notOnBorder = "Inside / Outside";
            if (point_X == x1 || point_X == x2)
            {
                if (point_Y >= y1 && point_Y <= y2)
                {
                    Console.WriteLine(border);
                }
                else
                {
                    Console.WriteLine(notOnBorder);
                }
            }
            else if (point_Y == y1 || point_Y == y2)
            {
                if (point_X >= x1 && point_X <= x2)
                {
                    Console.WriteLine(border);
                }
                else
                {
                    Console.WriteLine(notOnBorder);
                }
            }
            else
            {
                Console.WriteLine(notOnBorder);
            }
        }
    }
}
