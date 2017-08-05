using System;

namespace _01.FindTheLetter
{
    class FindTheLetter
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] array = Console.ReadLine().Split(' ');

            string letter = array[0];
            int occurrence = int.Parse(array[1]);
            int timesToOccur = 0;
            bool isPresent = false;

            for (int index = 0; index < text.Length; index++)
            {
                string currentSymbol = text[index].ToString();

                if(string.Compare(currentSymbol, letter, false) == 0)
                {
                    timesToOccur++;
                }

                if(timesToOccur == occurrence)
                {
                    isPresent = true;
                    Console.WriteLine(index);
                    return;
                }
            }

            if(!isPresent)
            {
                Console.WriteLine("Find the letter yourself!");
            }
        }
    }
}
