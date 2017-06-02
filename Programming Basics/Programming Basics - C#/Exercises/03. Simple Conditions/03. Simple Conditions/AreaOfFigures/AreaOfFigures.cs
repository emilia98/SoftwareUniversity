using System;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main()
        {
            string figure = Console.ReadLine();
            double area = 0;

            if (figure == "triangle")
            {
                double c = double.Parse(Console.ReadLine());
                double hc = double.Parse(Console.ReadLine());
                area = c * hc / 2;
            }
            else if (figure == "square")
            {
                double x = double.Parse(Console.ReadLine());
                area = x * x;
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            Console.WriteLine("{0:0.000}", area);
        }
    }
}
