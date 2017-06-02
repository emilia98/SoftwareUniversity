using System;

namespace _12.Generate_Rectangles
{
    class GenerateRectangles
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int minArea = int.Parse(Console.ReadLine());
            int area;
            //Counter, which counts the generated rectangles. We'll use it later.
            int rectangleCount = 0;

            for (int left = -n; left < n; left++)
            {
                for (int top = -n; top < n; top++)
                {
                    for (int right = left + 1; right <= n; right++)
                    {
                        for (int bottom = top + 1; bottom <= n; bottom++)
                        {
                            area = (right - left) * (bottom - top);
                            if (minArea <= area)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, area);
                                rectangleCount++;
                            }
                        }
                    }
                }
            }

            //Here, if the rectangleCount equals 0, the program will prints message "No", because it won't
            //generate even 1 rectangle

            if(rectangleCount == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
