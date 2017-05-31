using System;

namespace _05.WordInPlural_2
{
    class WordInPlural_2
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int length = word.Length;

            if (word.EndsWith("y") == true)
            {
                word = word.Remove(length - 1);
                word += "ies";         
            }
            else if(word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("ch") || word.EndsWith("sh")
                      || word.EndsWith("z") || word.EndsWith("x"))
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
