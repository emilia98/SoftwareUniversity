using System;

namespace _03.Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            string inputNumbers = Console.ReadLine();
            string inputNames = Console.ReadLine();

            string[] numbers = inputNumbers.Split(' ');
            string[] names = inputNames.Split(' ');

            string currentString = String.Empty;

            while(currentString != "done")
            {
                currentString = Console.ReadLine();

                for (int i = 0; i < numbers.Length; i++)
                {
                    if(currentString == numbers[i] || currentString == names[i])
                    {
                        Console.WriteLine("{0} -> {1}", names[i], numbers[i]);
                        break;
                    }
                }
            }
        }
    }
}
