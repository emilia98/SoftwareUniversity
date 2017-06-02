using System;

namespace _10.Rectangle_With_Stars
{
    class RectangleWithStars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int middleRows;
            int intervals;

            if(n % 2 != 0)
            {
                middleRows = n;
            }
            else
            {
                middleRows = n - 1;
            }

            Console.WriteLine(new string('%', 2 * n));

            if(middleRows == 1)
            {
                Console.WriteLine("%**%");
            }
            else
            {
                for (int row = 1; row <= middleRows; row++)
                {
                    if (row == (middleRows + 1) / 2)
                    {
                        intervals = (2 * n - 4) / 2;
                        Console.Write("%");
                        Console.Write(new string(' ', intervals));
                        Console.Write("**");
                        Console.Write(new string(' ', intervals));
                        Console.WriteLine("%");
                    }
                    else
                    {
                        intervals = 2 * n - 2;
                        Console.Write("%");
                        Console.Write(new string(' ',intervals));
                        Console.WriteLine("%");
                    }
                }
            }
           
            Console.WriteLine(new string('%',2 * n));
        }
    }
}
