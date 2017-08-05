using System;

namespace _02.Placeholders
{
    class Placeholders
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] splitInputAtTwo = input.Split(new string[] { " -> " },
                                                      StringSplitOptions.RemoveEmptyEntries);

                string[] placeholders = splitInputAtTwo[1].Split(new string[] { ", " },
                                                            StringSplitOptions.RemoveEmptyEntries);

                string sentences = splitInputAtTwo[0];

                for (int index = 0; index < placeholders.Length; index++)
                {
                    string placeholder = placeholders[index];
                    string searchInSentence = "{" + index + "}";

                    sentences = sentences.Replace(searchInSentence, placeholder);
                }
                Console.WriteLine(sentences);
                input = Console.ReadLine();
            }
        }
    }
}

/*
 * REAL INPUTS FOR TESTING:

INPUT:
I have a {0} and a {1} -> car, house
Cool, and I have a {0}. -> yacht
Darn... You beat me {0} {1} {12} -> with, this, hold
end

OUTPUT:
I have a car and a house
Cool, and I have a yacht.
Darn... You beat me with this {12}
 * */
