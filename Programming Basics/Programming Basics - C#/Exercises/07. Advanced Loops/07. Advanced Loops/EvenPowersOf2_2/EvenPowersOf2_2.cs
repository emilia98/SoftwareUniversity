﻿using System;

namespace EvenPowersOf2_2
{
    class EvenPowersOf2_2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 0; i <= n; i +=2)
            {
                Console.WriteLine(result);
                result *= 4;               
            }
        }
    }
}
