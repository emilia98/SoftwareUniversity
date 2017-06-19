using System;

namespace _17.Altitude
{
    class Altitude
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');

            long initialValue = long.Parse(splitInput[0]);
            int i = 1;
            string result = String.Empty;
            bool isCrashed = false;

            while (i < splitInput.Length)
            {
                string direction = splitInput[i];
                long number = long.Parse(splitInput[i + 1]);

                if (direction == "up")
                {
                    initialValue += number;
                }
                else if (direction == "down")
                {
                    initialValue -= number;
                }

                if (initialValue <= 0)
                {
                    result = "crashed";
                    isCrashed = true;
                    break;
                }
                i += 2;
            }

            if (isCrashed == false)
            {
                result += $"got through safely. current altitude: {initialValue}m";
            }

            Console.WriteLine(result);
        }
    }
}
