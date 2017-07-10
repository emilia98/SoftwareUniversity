using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MixedPhones
{
    class MixedPhones
    {
        static void Main()
        {
            string str = Console.ReadLine();
            SortedDictionary<string, long> phonebook = new SortedDictionary<string, long>();

            while(str != "Over")
            {
                char[] delimiter = { ' ', ':' };
                string[] splitedInput = str.Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string firstValue = splitedInput[0];
                string secondValue = splitedInput[1];

                long number;
                bool isSecondValueANumber = long.TryParse(secondValue, out number);
                string name;

                if(isSecondValueANumber)
                {
                    name = firstValue;                    
                    AddOrChangeValuesInPhonebook(phonebook, name, number);
                }
                else
                {
                    name = secondValue;
                    number = long.Parse(firstValue);                  
                    AddOrChangeValuesInPhonebook(phonebook, name, number);
                }             
                str = Console.ReadLine();
            }

            PrintTheResult(phonebook);
        }

        static SortedDictionary<string, long> AddOrChangeValuesInPhonebook(SortedDictionary<string, long> phonebook,
                                                                           string name, long number)
        {
            if (!phonebook.ContainsKey(name))
            {
                phonebook.Add(name, number);
            }
            else
            {
                phonebook[name] = number;
            }
            return phonebook;
        }

        static void PrintTheResult(SortedDictionary<string, long> phonebook)
        {
            foreach (KeyValuePair<string, long> pair in phonebook)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
