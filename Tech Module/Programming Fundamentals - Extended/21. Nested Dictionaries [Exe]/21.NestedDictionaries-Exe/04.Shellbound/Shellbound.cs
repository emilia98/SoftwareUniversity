using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Shellbound
{
    class Shellbound
    {
        static void Main()
        {
            var shellRegions = new Dictionary<string, HashSet<int>>();
            string command = Console.ReadLine();

            while (command != "Aggregate")
            {
                string[] input = command.Split(' ').ToArray();
                string region = input[0];
                int shellSize = int.Parse(input[1]);

                if(!shellRegions.ContainsKey(region))
                {
                    shellRegions.Add(region, new HashSet<int>());
                }
                shellRegions[region].Add(shellSize);

                command = Console.ReadLine();
            }

            
            foreach(var shellRegion in shellRegions)
            {
                string region = shellRegion.Key;
                HashSet<int> shellSizes = shellRegion.Value;

                int giantShellSize = CalculateSizeOfGiantShell(shellSizes);
                Console.WriteLine("{0} -> {1} ({2})",region, 
                                                     String.Join(", ", shellSizes),
                                                     giantShellSize);
            }
        }

        static int CalculateSizeOfGiantShell(HashSet<int> shellSizes)
        {
            int sum = 0;
            foreach(var currentSize in shellSizes)
            {
                sum += currentSize;
            }
            int giantShellSize = sum - (sum / shellSizes.Count);
            return giantShellSize;
        }
    }
}
