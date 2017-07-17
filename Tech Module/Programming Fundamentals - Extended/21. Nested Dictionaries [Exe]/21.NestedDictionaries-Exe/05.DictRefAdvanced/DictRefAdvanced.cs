using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DictRefAdvanced
{
    class DictRefAdvanced
    {
        static void Main()
        {
            var dictionaryReference = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] splitInput = input.Split(new string[] { " -> " },
                                                  StringSplitOptions.None).ToArray();
                string name = splitInput[0];
                string secondValue = splitInput[1];

                /*Here we get our list of integers, but only if we have only integers in the second part
                  of the input*/
                var listOfInts = new List<int>();
                listOfInts = CheckTheSecondValue(secondValue, listOfInts);

                /*If we haven't the name already, we store it in the dictionary. 
                  If we should ignore the current name, we'll delete it later in the code.
                */
                if (!dictionaryReference.ContainsKey(name))
                {
                    dictionaryReference.Add(name, new List<int>());
                }

                /*If we have integers in the list, we save number by number all the values we have
                  until we reach the last value in the current input list.
                */
                if (listOfInts.Count > 0)
                {
                    for (int index = 0; index < listOfInts.Count; index++)
                    {
                        int currentElement = listOfInts[index];
                        dictionaryReference[name].Add(currentElement);
                    }
                }
                /* If our second value isn't a list of integers, but a string (another name), 
                   we check if this value is contained in the dictionary.
                   -> If it contains in the dictionary, we check for the list of integers, that dictionary
                      stores opposite the name. The whole list, which is stored opposite the name, is
                      added to the new name.
                      (Ex.
                       John -> 1, 2, 3
                       Jack -> John
                       We find the list, which is opposite John, and start storing all the numbers, which
                       it contains, opposite Jack too)
                    -> If it's not, we delete the name, which is the first value
                */
                else
                {
                    if (dictionaryReference.ContainsKey(secondValue))
                    {
                        var otherValueList = dictionaryReference[secondValue];
                        for (int index = 0; index < otherValueList.Count; index++)
                        {
                            int currentElement = otherValueList[index];
                            dictionaryReference[name].Add(currentElement);
                        }
                    }
                    else
                    {
                        //Delete the first value, because we couldn't match it with already existing name
                        dictionaryReference.Remove(name);
                    }
                }               
                input = Console.ReadLine();
            }

            foreach (var reference in dictionaryReference)
            {
                string name = reference.Key;
                List<int> values = dictionaryReference[name];
                Console.WriteLine("{0} === {1}", name, String.Join(", ", values));
            }
        }

        /*Here we find if the second value, we've enteredq contains only integers, or a string(name)
          If it contains only integers, we return a list with all numbers, so we could use it later 
          in the code.
        */
        static List<int> CheckTheSecondValue(string secondValue, List<int> listOfInts)
        {
            List<string> list = secondValue.Split(new string[] { ", " },
                                              StringSplitOptions.None).ToList();
            for (int index = 0; index < list.Count; index++)
            {
                int currentNumber;
                bool isNumber = int.TryParse(list[index], out currentNumber);

                if (isNumber)
                {
                    listOfInts.Add(currentNumber);
                }
                else
                {
                    break;
                }
            }
            return listOfInts;
        }
    }
}

/* TRY:
   Input:
   Donald -> 2, 2, 2
   Isacc -> 1, 2, 3
   John -> Isacc
   Donald -> 3, 3, 3
   John -> Donald
   Isacc -> 4
   end

   Output:
   Donald === 2, 2, 2, 3, 3, 3
   Isacc === 1, 2, 3, 4
   John === 1, 2, 3, 2, 2, 2, 3, 3, 3
*/
