using System;
using System.Linq;

namespace _04.GrabAndGo_2
{
    class Program
    {
        static void Main()
        {
            //input:
            var array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            int lastIndex = Array.LastIndexOf(array, num);

            if (lastIndex == -1)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                long sum = array.Skip(0).Take(lastIndex).Aggregate((a, b) => a + b);
                Console.WriteLine(sum);
            }
            //goto input;
        }
    }
}
