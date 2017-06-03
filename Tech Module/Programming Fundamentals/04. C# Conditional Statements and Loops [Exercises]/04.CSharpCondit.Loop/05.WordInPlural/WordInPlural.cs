using System;

namespace _05.WordInPlural
{
    class WordInPlural
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int length = word.Length;

            char lastSym = word[length - 1];
            char almostLast = word[length - 2];

            if (lastSym == 'y')
            {
                word = word.Remove(length - 1);
                word += "ies";
            }
            else if(lastSym == 'o' || lastSym == 's' || lastSym == 'x' || lastSym == 'z' ||
                    (lastSym == 'h' && almostLast == 'c') || (lastSym == 'h' && almostLast == 's'))
            {
                word += "es";
            }
            else 
            {
                word += "s";
            }
            Console.WriteLine(word);
        }
    }
}
