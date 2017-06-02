using System;

namespace SumSeconds
{
    class SumSeconds
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

            if (minutes == 0)
            {
                Console.WriteLine("0:{0:00}", seconds);
            }
            else if (minutes == 1)
            {
                Console.WriteLine("1:{0:00}", seconds);
            }
            else if (minutes == 2)
            {
                Console.WriteLine("2:{0:00}", seconds);
            }
        }
    }
}
