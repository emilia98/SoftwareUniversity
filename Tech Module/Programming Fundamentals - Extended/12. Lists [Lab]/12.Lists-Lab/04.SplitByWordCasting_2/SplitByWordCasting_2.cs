using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SplitByWordCasting_2
{
    class SplitByWordCasting_2
    {
        static List<string> text = new List<string>();
        
        static void Main()
        {
            text = GetNewList(text);

            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> lowerCase = new List<string>();
            CheckEachWordInList(text, lowerCase, mixedCase, upperCase);
            string finalResult = GetFinalResult(mixedCase, upperCase, lowerCase);
            Console.WriteLine(finalResult);

        }

        static List<string> GetNewList(List<string> text)
        {
            char[] delimiter = new char[] {',' , ';', ':', '.', '!', '(',
                                            ')', '\"', '\'', '\\', '/', '[',
                                            ']', ' '};
            text = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToList();

            return text;
        }

        static Tuple<List<string>, List<string>, List<string>> CheckEachWordInList(List<string> text, 
                                                                     List<string> lowerCase,
                                                                     List<string> mixedCase,
                                                                     List<string> upperCase)
        {
            for (int wordCount = 0; wordCount < text.Count; wordCount++)
            {
                string currentWord = text[wordCount];
                int lowerCaseCnt = CountLowerCase(currentWord);
                int upperCaseCnt = CountUpperCase(currentWord);
                int mixedCaseCnt = CountMixedCase(currentWord);

                if (IsLowerCase(lowerCaseCnt, upperCaseCnt, mixedCaseCnt))
                {
                    lowerCase.Add(currentWord);
                }
                else if(IsUpperCase(lowerCaseCnt, upperCaseCnt, mixedCaseCnt))
                {
                    upperCase.Add(currentWord);
                }
                else
                {
                    mixedCase.Add(currentWord);
                }
            }

            return new Tuple<List<string>, List<string>, List<string>>(lowerCase, mixedCase, upperCase);
        }
        

        static int CountMixedCase(string currentWord)
        {
            int mixedCaseCnt = 0;

            for (int symb = 0; symb < currentWord.Length; symb++)
            {
                if (currentWord[symb] < 65 ||
                    currentWord[symb] > 122 ||
                    (currentWord[symb] > 90 && currentWord[symb] < 97))
                {
                    mixedCaseCnt++;
                }
            }
            return mixedCaseCnt;
        }

        static int CountUpperCase(string currentWord)
        {
            int upperCaseCnt = 0;

            for (int symb = 0; symb < currentWord.Length; symb++)
            {
                if (currentWord[symb] >= 65 && currentWord[symb] <= 90)
                {
                    upperCaseCnt++;
                }
            }
            return upperCaseCnt;
        }

        static int CountLowerCase(string currentWord)
        {
            int lowerCaseCnt = 0;

            for (int symb = 0; symb < currentWord.Length; symb++)
            {
                if (currentWord[symb] >= 97 && currentWord[symb] <= 121)
                {
                    lowerCaseCnt++;
                }
            }
            return lowerCaseCnt;
        }

        static bool IsLowerCase(int lowerCaseCnt, int upperCaseCnt, int mixedCaseCnt)
        {
            if (lowerCaseCnt > 0 && (mixedCaseCnt == 0 && upperCaseCnt == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsUpperCase(int lowerCaseCnt, int upperCaseCnt, int mixedCaseCnt)
        {
            if (upperCaseCnt > 0 && (mixedCaseCnt == 0 && lowerCaseCnt == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string GetFinalResult(List<string> mixedCase,List<string> upperCase, List<string> lowerCase)
        {
            string result = String.Empty;
            result += $"Lower-case: {String.Join(", ", lowerCase)} \n";
            result += $"Mixed-case: {String.Join(", ", mixedCase)} \n";
            result += $"Upper-case: {String.Join(", ", upperCase)} \n";
            return result;
        }
    }
}
