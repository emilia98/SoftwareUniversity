using System;

namespace _6.Digits
{
    class Digits
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int d1, d2, d3;
            int rows, cols;

            //d1,d2,d3 -> variables, in which we store the value of each digit of the number
            d1 = number / 100;
            d2 = (number / 10) % 10;
            d3 = number % 10;

            //Find the count of rows and cols, with the given condition
            rows = d1 + d2;
            cols = d1 + d3;

            for (int row = 1; row <= rows; row++)
            {
                for (int col = 1; col <= cols; col++)
                {
                    if (number % 5 == 0)
                    {
                        number -= d1;
                    }
                    else if (number % 3 == 0)
                    {
                        number -= d2;
                    }
                    else
                    {
                        number += d3;
                    }
                    Console.Write("{0} ", number);
                }
                Console.WriteLine();
            }
        }
    }
}
