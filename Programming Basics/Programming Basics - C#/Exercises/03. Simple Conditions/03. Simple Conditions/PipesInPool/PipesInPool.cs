using System;

namespace PipesInPool
{
    class PipesInPool
    {
        static void Main()
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double filledPool = 0;
            filledPool = (p1 + p2) * h;

            double full;
            double pipe1Fill;
            double pipe2Fill;
            double overflow;

            if (filledPool <= v)
            {
                full = Math.Floor((filledPool / v)*100);
                pipe1Fill = Math.Floor((p1 * h / filledPool) * 100);
                pipe2Fill = Math.Floor((p2 * h / filledPool) * 100);
                Console.WriteLine("The pool is {0:0}% full. Pipe 1: {1:0}%. Pipe 2: {2:0}%.", full, pipe1Fill, pipe2Fill);
            }
            else
            {
                overflow = filledPool - v;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, overflow);
            }
        }
    }
}
