using System;
using System.Linq;

namespace _03.SafeManipulation
{
    class SafeManipulation
    {
        static void Main()
        {
            //input: 
            var words = Console.ReadLine().Split(' ').ToArray();
            string command = Console.ReadLine();

            while (command != "END")
            {
                var splitCommand = command.Split(' ').ToArray();
                if (command == "Reverse")
                {
                    words = words.Reverse().ToArray();
                }
                else if (command == "Distinct")
                {
                    words = words.Distinct().ToArray();
                }
                else if (splitCommand[0] == "Replace")
                {
                    var indexToRemove = int.Parse(splitCommand[1]);
                    var strToRemove = splitCommand[2];

                    if (indexToRemove >= 0 && indexToRemove < words.Length)
                    {
                        words[indexToRemove] = strToRemove;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", words));
            //goto input;
        }
    }
}
