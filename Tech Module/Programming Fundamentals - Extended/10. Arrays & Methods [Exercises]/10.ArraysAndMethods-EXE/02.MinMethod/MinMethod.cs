using System;

namespace _02.MinMethod
{
    class MinMethod
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int min = GetMin(a, b);
            min = GetMin(min, c);
            Console.WriteLine(min);
        }

        static int GetMin(int num1, int num2)
        {
            int min;
            if(num1 <= num2)
            {
                min = num1;
            }
            else
            {
                min = num2;
            }
            return min;
        }
    }
}
