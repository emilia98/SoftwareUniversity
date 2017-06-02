using System;

namespace InchToCm
{
    class InchToCm
    {
        static void Main()
        {
            Console.Write("inches = ");
            double xInches = double.Parse(Console.ReadLine());
            double xCm;
            xCm = xInches * 2.54;

            Console.Write("centimeters = ");
            Console.WriteLine(xCm);
        }
    }
}
