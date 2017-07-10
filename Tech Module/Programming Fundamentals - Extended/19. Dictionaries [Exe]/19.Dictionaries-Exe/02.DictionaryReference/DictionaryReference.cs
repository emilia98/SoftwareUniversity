using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.DictionaryReference
{
    class DictionaryReference
    {
        static void Main()
        {
            string str = Console.ReadLine();
            Dictionary<string, int> dictReference = new Dictionary<string, int>();

            while (str != "end")
            {
                char[] delimiter = { ' ', '='};
                string[] splitedString = str.Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = splitedString[0];
                string secondName = splitedString[1];

                int value;
                bool isNumber = int.TryParse(secondName, out value);

                if(!dictReference.ContainsKey(name))
                {
                    if(isNumber)
                    {
                        dictReference.Add(name, value);
                    }
                    else if(dictReference.ContainsKey(secondName))
                    {
                        dictReference.Add(name, dictReference[secondName]);
                    }
                }
                else
                {
                    if (isNumber)
                    {
                        dictReference[name] = value;
                    }
                    else if (dictReference.ContainsKey(secondName))
                    {
                        dictReference[name] = dictReference[secondName];
                    }
                }
                str = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int> pair in dictReference)
            {
                Console.WriteLine("{0} === {1}", pair.Key, pair.Value);
            }
        }
    }
}
