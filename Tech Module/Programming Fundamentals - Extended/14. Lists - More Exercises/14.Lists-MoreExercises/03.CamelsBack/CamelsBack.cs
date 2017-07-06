using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CamelsBack
{
    class CamelsBack
    {
        static void Main()
        {
            List<int> buildings = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelBackSize = int.Parse(Console.ReadLine());

            int countBuildings = buildings.Count;
            int rounds = 0;

            while(countBuildings > camelBackSize)
            {
                buildings.RemoveAt(0);
                countBuildings = buildings.Count; //same as countBuildings--;
                buildings.RemoveAt(countBuildings - 1);
                countBuildings--;
                rounds++;
            }

            string result = string.Empty;
            if(rounds == 0)
            {
                result += "already stable:";
            }
            else
            {
                result += $"{rounds} rounds \n";
                result += "remaining:";
            }
            Console.WriteLine("{0} {1}", result, String.Join(" ", buildings));
        }
    }
}
