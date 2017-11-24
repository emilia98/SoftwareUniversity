using System;
using System.Linq;

namespace _02.ManipulateArray_2
{
    class ManipulateArray_2
    {
        static void Main()
        {
            //input:
            var words = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int counter = 1; counter <= n; counter++)
            {
                string command = Console.ReadLine();

                if (command == "Reverse")
                {
                    words = words.Reverse().ToArray();
                }
                else if (command == "Distinct")
                {
                    words = words.Distinct().ToArray();
                }
                else
                {
                    var splitCommand = command.Split(' ').ToArray();
                    int index = int.Parse(splitCommand[1]);
                    string strToReplace = splitCommand[2];

                    words[index] = strToReplace;
                }
            }
            Console.WriteLine(String.Join(", ", words));
            //goto input;
        }
    }
}
