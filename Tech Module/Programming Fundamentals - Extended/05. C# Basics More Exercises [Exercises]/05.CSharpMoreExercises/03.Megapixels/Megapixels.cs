using System;

namespace _03.Megapixels
{
    class Megapixels
    {
        static void Main()
        {
            ushort width = ushort.Parse(Console.ReadLine());
            ushort height = ushort.Parse(Console.ReadLine());

            double megapixels = (width * height * 1.0) / 1000000;

            Console.WriteLine($"{width}x{height} => {Math.Round(megapixels,1)}MP");
        }
    }
}
