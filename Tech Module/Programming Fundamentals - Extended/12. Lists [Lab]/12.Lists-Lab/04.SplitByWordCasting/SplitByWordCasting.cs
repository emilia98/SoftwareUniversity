using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SplitByWordCasting
{
    class SplitByWordCasting
    {
        static void Main()
        {
            char[] delimiter = new char[] {',' , ';', ':', '.', '!', '(',
                                            ')', '\"', '\'', '\\', '/', '[', 
                                            ']', ' '};
            List<string> text = Console.ReadLine().Split(delimiter, 
                                                         StringSplitOptions.RemoveEmptyEntries).ToList();
            
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> lowerCase = new List<string>();

            for (int wordCount = 0; wordCount < text.Count; wordCount++)
            {
                string currentWord = text[wordCount];
                int mixedCaseCnt = 0;
                int lowerCaseCnt = 0;
                int upperCaseCnt = 0;

                for (int symb = 0; symb < currentWord.Length; symb++)
                {
                    if (currentWord[symb] >= 65 && currentWord[symb] <= 90)
                    {
                        upperCaseCnt++;
                    }
                    else if (currentWord[symb] >= 97 && currentWord[symb] <= 121)
                    {
                        lowerCaseCnt++;
                    }
                    else
                    {
                        mixedCaseCnt++;
                    }
                }
                
                if(lowerCaseCnt > 0 && (mixedCaseCnt == 0 && upperCaseCnt == 0))
                {
                    lowerCase.Add(currentWord);
                }
                else if(upperCaseCnt > 0 && (mixedCaseCnt == 0 && lowerCaseCnt == 0))
                {
                    upperCase.Add(currentWord);
                }
                else
                {
                    mixedCase.Add(currentWord);
                }
            }

            Console.WriteLine("Lower-case: {0}", String.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", String.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", String.Join(", ", upperCase));
        }
    }
}
