﻿using System;
using System.Linq;

namespace _03.ReverseArray_3
{
    class ReverseArray_3
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = array.Length;

            for (int index = 0; index < n/ 2; index++)
            {
                int start = index;
                int end = n - 1 - start;
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
            }
            Console.WriteLine(String.Join(" ", array));
        }
    }
}
