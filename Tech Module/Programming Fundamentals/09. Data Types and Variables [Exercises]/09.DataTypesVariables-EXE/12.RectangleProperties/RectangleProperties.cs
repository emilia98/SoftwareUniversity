﻿using System;

namespace _12.RectangleProperties
{
    class RectangleProperties
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = 2 * (width + height);
            double area = width * height;
            double diagonal = Math.Sqrt(width * width + height * height);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
