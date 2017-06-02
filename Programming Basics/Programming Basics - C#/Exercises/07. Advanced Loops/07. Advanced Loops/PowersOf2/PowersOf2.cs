//In almost all cases it's correct, but sometimes causes time limits => So, it's not the best solution
using System;

namespace PowersOf2
{
    class PowersOf2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int powerOfN = (int)Math.Pow(2, n);

            for (int i = 1; i <= powerOfN; i *= 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
