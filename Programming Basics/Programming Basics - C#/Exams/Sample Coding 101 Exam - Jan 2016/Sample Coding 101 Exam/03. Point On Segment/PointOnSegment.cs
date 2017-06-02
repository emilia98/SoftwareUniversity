using System;

namespace _03.Point_On_Segment
{
    class PointOnSegment
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            string position = "";
            int minDistance;

            if (first < second)
            {
                if (point >= first && point <= second)
                {
                    position = "in";
                }
                else
                {
                    position = "out";
                }

                minDistance = Math.Abs(first - point);

                if (minDistance > Math.Abs(second - point))
                {
                    minDistance = Math.Abs(second - point);
                }
            }
            else
            {
                if (point >= second && point <= first)
                {
                    position = "in";
                }
                else
                {
                    position = "out";
                }

                minDistance = Math.Abs(first - point);

                if (minDistance > Math.Abs(second - point))
                {
                    minDistance = Math.Abs(second - point);
                }
            }
            Console.WriteLine(position);
            Console.WriteLine(minDistance);
        }
    }
}
