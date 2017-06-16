using System;

namespace _14.BoatSimulator
{
    class BoatSimulator
    {
        static void Main()
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            uint n = uint.Parse(Console.ReadLine());

            int tilesFirstBoat = 0, tilesSecondBoat = 0;
            bool isThereAWinner = false;
            char winner = ' ';

            for (uint move = 1; move <= n; move++)
            {
                string str = Console.ReadLine();

                if(str == "UPGRADE")
                {
                    firstBoat = (char)(firstBoat + 3);
                    secondBoat = (char)(secondBoat + 3);
                    continue;
                }
                else
                {
                    if(move % 2 == 0)
                    {
                        tilesSecondBoat += str.Length;
                    }
                    else
                    {
                        tilesFirstBoat += str.Length;
                    }
                }

                if(tilesFirstBoat >= 50)
                {
                    isThereAWinner = true;
                    winner = firstBoat;
                    break;
                }
                else if(tilesSecondBoat >= 50)
                {
                    isThereAWinner = true;
                    winner = secondBoat;
                    break;
                }
            }

            if(isThereAWinner == false)
            {
                if(tilesFirstBoat >= tilesSecondBoat)
                {
                    winner = firstBoat;
                }
                else
                {
                    winner = secondBoat;
                }
            }
            Console.WriteLine(winner);
        }
    }
}
