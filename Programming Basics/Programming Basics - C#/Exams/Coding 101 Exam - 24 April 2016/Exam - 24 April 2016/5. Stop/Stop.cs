using System;

namespace _5.Stop
{
    class Stop
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int halfDotsFirstLine = n + 1;
            int underscoresFirtsLine = 2 * n + 1;
            int halfDots = halfDotsFirstLine - 1;
            int underscores = underscoresFirtsLine - 2;

            //For the first n + 1 rows, we have a for-loop, which prints the FIRST PART of the "Stop" sign
            for (int row = 1; row <= n + 1; row++)
            {
                if (row == 1)
                {
                    Console.Write(new string('.', halfDotsFirstLine));
                    Console.Write(new string('_', underscoresFirtsLine));
                    Console.Write(new string('.', halfDotsFirstLine));
                }
                else
                {
                    Console.Write(new string('.', halfDots));
                    Console.Write("//");
                    Console.Write(new string('_', underscores));
                    Console.Write("\\\\");
                    Console.Write(new string('.', halfDots));
                    underscores += 2;
                    halfDots -= 1;
                }

                Console.WriteLine();
            }

            //The second for-loop is for the MIDDLE (SECOND) PART of the "STOP" sign -> With text "STOP!" 
            //Reduce the variable underscore,because we've increased it, but unnecessarily at the last execution of
            // else in the first loop
            underscores -= 2;

            Console.Write("//");
            Console.Write(new string('_', (underscores + 2 - 5) / 2));
            Console.Write("STOP!");
            Console.Write(new string('_', (underscores + 2 - 5) / 2));
            Console.Write("\\\\");
            Console.WriteLine();

            //The third for-loop is for the FINAL (THIRD) PART of the "STOP" sign 
            halfDots = 0;  //-> at first, the dots are 0, but later the increses by one on each side 

            underscores += 2; // -> Several rows above, we decreased the count of underscores by 2, so now 
            // we want the before-decreasion count of underscores, so we need to increase this count by 2

            for (int row = n + 2; row <= 2 * n + 1; row++)
            {
                Console.Write(new string('.', halfDots));
                Console.Write("\\\\");
                Console.Write(new string('_', underscores));
                Console.Write("//");
                Console.Write(new string('.', halfDots));
                underscores -= 2;
                halfDots += 1;

                Console.WriteLine();
            }
        }
    }
}
