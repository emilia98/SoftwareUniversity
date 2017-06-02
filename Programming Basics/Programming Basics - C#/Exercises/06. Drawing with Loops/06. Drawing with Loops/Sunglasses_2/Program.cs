using System;

namespace Sunglasses_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cols = 5 * n;


            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if ((col >= 2 * n) && (col < (3 * n)))
                    {
                        if (n % 2 == 0 && row == n / 2)
                        {
                            Console.Write("|");
                        }
                        else if(n % 2 == 1 && row == n / 2)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else if ( (row == 0 || row == n-1) ||
                             ((col == 0) ||
                              (col == 2 * n - 1) ||
                              (col == 3 * n ) ||
                              (col == 5 * n - 1)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("/");
                    }
                }
                
                Console.WriteLine();
            }
        }
    }
}
