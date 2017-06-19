using System;

namespace _18.BallisticsTraining
{
    class BallisticsTraining
    {
        static void Main()
        {
            string targets = Console.ReadLine();
            string commands = Console.ReadLine();

            string[] splitTargets = targets.Split(' ');
            string[] splitCommands = commands.Split(' ');

            long target_X = long.Parse(splitTargets[0]);
            long target_Y = long.Parse(splitTargets[1]);
            long x = 0, y = 0;

            for (int i = 0; i < splitCommands.Length - 1; i += 2)
            {
                string direction = splitCommands[i];
                long number = long.Parse(splitCommands[i + 1]);

                if(direction == "up")
                {
                    y += number;
                }
                else if(direction == "down")
                {
                    y -= number;
                }
                else if (direction == "left")
                {
                    x -= number;
                }
                else if (direction == "right")
                {
                    x += number;
                }
            }

            string result;
            if(target_X == x && target_Y == y)
            {
                result = "got 'em!";
            }
            else
            {
                result = "better luck next time...";
            }

            Console.WriteLine("firing at [{0}, {1}]",x,y);
            Console.WriteLine(result);
        }
    }
}
