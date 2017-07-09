using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Japanese_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> theList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> players = Console.ReadLine().Split(' ').ToList();

            int muzzlePosition = 0;
            for (int i = 0; i < theList.Count; i++)
            {
                if (theList[i] == 1)
                {
                    muzzlePosition = i;
                }
            }

            int playerPosition = 0;
            for (int i = 0; i < players.Count - 1; i++)
            {

                string[] temp = players[i].Split(',').ToArray();
                string command = temp[1];
                int strength = int.Parse(temp[0]);
                if (command == "Left")
                {
                    while (strength > 0)
                    {
                        if (muzzlePosition == 0)
                        {
                            muzzlePosition = 5;
                        }
                        muzzlePosition--;
                        strength--;
                    }
                   // playerPosition = Math.Abs((strength + playerPosition) % theList.Count);

                }
                else if (command == "Right")
                {
                    while (strength > 0)
                    {
                        
                        if (muzzlePosition > 5)
                        {
                            muzzlePosition = 0;
                        }
                        muzzlePosition++;
                        strength--;
                    }
                    // playerPosition = Math.Abs((strength - playerPosition) % theList.Count);

                }

                if (muzzlePosition == playerPosition)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    return;
                }
                playerPosition = i;
            }
            Console.WriteLine("Everybody got lucky!");
        }
    }
}