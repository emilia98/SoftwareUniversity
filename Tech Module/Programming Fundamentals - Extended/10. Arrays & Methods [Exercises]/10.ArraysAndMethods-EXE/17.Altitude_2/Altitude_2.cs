using System;

namespace _17.Altitude_2
{
    class Altitude_2
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');

            string result = GetAResult(splitInput);
            Console.WriteLine(result);
        }

        static string GetAResult(string[] array)
        {
            long initialValue = long.Parse(array[0]);
            int i = 1;
            string result = String.Empty;
            bool isCrashed = false;

            while(i < array.Length)
            {
                initialValue = CalculateNewInitialValue(array, initialValue, i);

                if(initialValue <= 0)
                {
                    result = "crashed";
                    isCrashed = true;
                    break;
                }
                i += 2;
            }

            if(isCrashed == false)
            {
                result = $"got through safely. current altitude: {initialValue}m";
            }
            return result;
        }

        static long CalculateNewInitialValue(string[] array, long initialValue, int i)
        {
            string direction = array[i];
            int number = int.Parse(array[i + 1]);

            if(direction == "up")
            {
                initialValue += number;
            }
            else if(direction == "down")
            {
                initialValue -= number;
            }
            return initialValue;
        }
    }
}
