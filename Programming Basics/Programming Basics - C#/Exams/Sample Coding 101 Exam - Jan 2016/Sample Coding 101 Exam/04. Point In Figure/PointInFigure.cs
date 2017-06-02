using System;

namespace _04.Point_In_Figure
{
    class PointInFigure
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            bool isOut1, isOut2, isOut3;

            //For the first rectangle -> from right to left
            if((y >= -3 && y <= 1) && (x >= 2 && x <= 4))
            {
                isOut1 = false;
            }
            else
            {
                isOut1 = true;
            }
            //For the second rectangles -> which is the biggest
            if ((y >= -5 && y <= 3) && (x >= 4 && x <= 10))
            {
                isOut2 = false;
            }
            else
            {
                isOut2 = true;
            }

            //For the third rectangle -> from right to left
            if ((y >= -3 && y <= 1) && (x >= 10 && x <= 12))
            {
                isOut3 = false;
            }
            else
            {
                isOut3 = true;
            }

            if (isOut1 && isOut2 && isOut3)
            {
                Console.WriteLine("out");
            }
            else
            {
                Console.WriteLine("in");
            }

        }
    }
}
