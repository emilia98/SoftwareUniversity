using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CamelsBack_2
{
    class CamelsBack_2
    {        
        static void Main()
        {
            List<int> buildings = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelBacksSize = int.Parse(Console.ReadLine());
            string result = GetAResult(buildings, camelBacksSize);
            Console.WriteLine(result);
        }

        static string GetAResult(List<int> buildings, int camelBacksSize)
        {
            int countBuildings = buildings.Count;
            int rounds = 0;

            while(countBuildings > camelBacksSize)
            {
                buildings.RemoveAt(0);
                countBuildings--; //The same as countBuildings = buildings.Count; 
                buildings.RemoveAt(countBuildings - 1);
                countBuildings = buildings.Count;
                rounds++;
            }

            string result = String.Empty;
            if(rounds == 0)
            {
                result += "already stable: ";
            }
            else
            {
                result += $"{rounds} rounds\n";
                result += "remaining: ";
            }
            result += String.Join(" ", buildings);
            return result;
        }
    }
}
