using System;

namespace Sequence2k_1
{
    class Sequence2k_1
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i = i*2 + 1)
            {
                Console.WriteLine(i);              
            }
        }
    }
}
