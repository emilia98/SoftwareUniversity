using System;

namespace _07.Sum_Step_3
{
    class SumStep3
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int number;
            int sum1 = 0, sum2 = 0, sum3 = 0;

            for (int i = 1; i <= n; i++)
            {
                number = int.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    sum3 += number;
                }
                else if(i % 3 == 2 && i % 3 != 0)
                {
                    sum2 += number;
                }
                else
                {
                    sum1 += number;
                }
            }
            Console.WriteLine("sum1 = {0}",sum1);
            Console.WriteLine("sum2 = {0}",sum2);
            Console.WriteLine("sum3 = {0}",sum3);
        }
    }
}
