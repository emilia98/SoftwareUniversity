using System;

namespace RectangleNxNStars
{
    class RectangleNxNStars_1
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*',n));
            }
        }
    }
}
