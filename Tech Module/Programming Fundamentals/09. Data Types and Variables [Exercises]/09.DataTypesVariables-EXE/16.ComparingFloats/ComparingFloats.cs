using System;

namespace _16.ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            bool areEqual;

            if (Math.Abs(a - b) <= eps)
            {
                areEqual = true;
            }
            else
            {
                areEqual = false;
            }

            Console.WriteLine(areEqual);
        }
    }
}
