using System;

namespace AreaOfaRectangle
{
    class AreaOfaRectangle
    {
        static void Main()
        {
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());
            decimal area;
            area = a * b;
            Console.WriteLine(area);
        }
    }
}
