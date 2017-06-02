using System;

namespace _6.Battles
{
    class Battles
    {
        static void Main()
        {
            int pokemon1 = int.Parse(Console.ReadLine());
            int pokemon2 = int.Parse(Console.ReadLine());
            int maxFights = int.Parse(Console.ReadLine());

            int currentFight = 0;

            for (int p1 = 1; p1 <= pokemon1; p1++)
            {
                for (int p2 = 1; p2 <= pokemon2; p2++)
                {
                    currentFight++;

                    if (currentFight > maxFights)
                    {
                        break;
                    }
                    Console.Write("({0} <-> {1}) ", p1, p2);
                }
            }
            Console.WriteLine();
        }
    }
}
