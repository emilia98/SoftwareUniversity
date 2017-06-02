using System;

namespace Sequence2k_1_2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            while(num <= n)
            {
                Console.WriteLine(num);
                num = 2 * num + 1;               
            }
        }
    }
}
