// WITHOUT IF-ELSE
using System;

namespace SumSeconds_2
{
    class SumSeconds2
    {
        static void Main()
        {
            int comp1 = int.Parse(Console.ReadLine());
            int comp2 = int.Parse(Console.ReadLine());
            int comp3 = int.Parse(Console.ReadLine());
            int sum;
            int minutes;
            int seconds;

            sum = comp1 + comp2 + comp3;
            minutes = sum / 60;
            seconds = sum - (minutes * 60);

            Console.WriteLine("{0:0}:{1:00}", minutes,seconds);
        }
    }
}
