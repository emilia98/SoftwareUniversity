using System;

namespace PointInRectangle
{
    class PointInRectangle
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double point_x = double.Parse(Console.ReadLine());
            double point_y = double.Parse(Console.ReadLine());

            if(x1 <= point_x && x2 >= point_x && y1 <= point_y && y2 >= point_y)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
