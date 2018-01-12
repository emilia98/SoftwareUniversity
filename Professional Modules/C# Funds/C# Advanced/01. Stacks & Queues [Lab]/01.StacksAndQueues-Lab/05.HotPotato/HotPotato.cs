using System;
using System.Collections.Generic;

namespace _05.HotPotato
{
    class HotPotato
    {
        static void Main()
        {
            var kids = Console.ReadLine().Split(' ');
            int number = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(kids);
            
            while(queue.Count > 1)
            {
                for(var cnt = 1; cnt < number; cnt++)
                {
                    string kid = queue.Dequeue();
                    queue.Enqueue(kid);
                }

                string removed = queue.Dequeue();
                Console.WriteLine($"Removed {removed}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
