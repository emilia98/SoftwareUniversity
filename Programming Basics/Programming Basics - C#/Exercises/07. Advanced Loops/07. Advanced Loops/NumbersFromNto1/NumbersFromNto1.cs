﻿using System;

namespace NumbersFromNto1
{
    class NumbersFromNto1
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
