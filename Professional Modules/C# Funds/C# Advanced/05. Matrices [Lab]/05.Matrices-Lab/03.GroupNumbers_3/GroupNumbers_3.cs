using System;
using System.Linq;

namespace _03.GroupNumbers_3
{
    class GroupNumbers_3
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ', ',' },
                                             StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();

            var zero = numbers.Where(x => Math.Abs(x % 3) == 0);
            var one = numbers.Where(x => Math.Abs(x % 3) == 1);
            var two = numbers.Where(x => Math.Abs(x % 3) == 2);

            Console.WriteLine(String.Join(" ", zero));
            Console.WriteLine(String.Join(" ", one));
            Console.WriteLine(String.Join(" ", two));
        }
    }
}
