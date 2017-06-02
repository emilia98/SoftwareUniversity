using System;

namespace DrawFort
{
    class DrawFort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int slashes = 4;
            int xors = n / 2;
            int underscores;
            int intervals = 2 * n - 2;

            underscores = 2 * n - (slashes + xors * 2);

            for (int i = 1; i <= n; i++)
            {
                //First row is the top of the fort
                if (i == 1)
                {
                    //First part of the top of the fort -> in some cases (where underscores == 0) are
                    //the first N'th elements
                    Console.Write("/");
                    Console.Write(new string('^', xors));
                    Console.Write("\\");

                    //Checks if there are underscores -> 
                    if (underscores > 0)
                    {
                        Console.Write(new string('_', underscores));
                    }
                    //Second part of the top of the fort -> in some cases (where underscores == 0) are
                    // the second N'th elements
                    Console.Write("/");
                    Console.Write(new string('^', xors));
                    Console.Write("\\");
                }
                //The last row is the bottom of the fort
                else if (i == n)
                {
                    //The intervals equals 0 when there aren't any underscores in the first line of the fort.
                    intervals = underscores;
                    //The underscores here are equal to count of xors, because in every case we should 
                    //print them in the bottom of the fort
                    underscores = xors;

                    Console.Write("\\");
                    Console.Write(new string('_', underscores));
                    Console.Write("/");
                    Console.Write(new string(' ', intervals));
                    Console.Write("\\");
                    Console.Write(new string('_', underscores));
                    Console.Write("/");
                }
                //The last but one row of the fort -> It's important if the underscores are more than 0
                else if (i == n - 1 && underscores > 0)
                {
                    //Reduces the count of the intervals, which are replaced by the same count underscores.
                    intervals -= underscores;
                    Console.Write("|");
                    Console.Write(new string(' ', intervals / 2));
                    //This special case is different from the other, because of the underscores
                    Console.Write(new string('_', underscores));
                    Console.Write(new string(' ', intervals / 2));
                    Console.Write("|");
                }
                // For all other rows prints two Vertical bars ('|'), so between each there are certain count intervals
                // which we've pointed in the beggining
                else
                {
                    Console.Write("|");
                    Console.Write(new string(' ', intervals));
                    Console.Write("|");
                }
                Console.WriteLine();
            }
        }
    }
}
