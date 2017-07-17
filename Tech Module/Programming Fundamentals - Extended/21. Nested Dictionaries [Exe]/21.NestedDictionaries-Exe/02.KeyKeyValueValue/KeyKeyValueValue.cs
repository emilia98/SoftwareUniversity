using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KeyKeyValueValue
{
    class KeyKeyValueValue
    {
        static void Main()
        {
            var pairs = new Dictionary<string, List<string>>();
            string key = Console.ReadLine();
            string value = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            /*We shouldn't print only the key-value pairs, when both key and value are containing in
              the input we've entered. 
              If we have a value, which contains in out input, but we have a value which don't, 
              we should print the KEY.

              Example:
                INPUT:
                    bug
                    hi
                    3
                    bug => hooo
                    bu => hil
                    bag => hola
                OUTPUT:
                    bug:
            */
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " => " },
                                                          StringSplitOptions.None).ToArray();
                string searchKey = input[0];
                string[] valuesArray = input[1].Split(';').ToArray();

                if (searchKey.Contains(key))
                {
                    if (!pairs.ContainsKey(searchKey))
                    {
                        pairs.Add(searchKey, new List<string>());
                    }
                    for (int index = 0; index < valuesArray.Length; index++)
                    {
                        string searchValue = valuesArray[index];

                        if (searchValue.Contains(value))
                        {
                            pairs[searchKey].Add(searchValue);
                        }
                    }                                       
                }               
            }
            foreach (var pair in pairs)
            {
                string currentKey = pair.Key;
                Console.WriteLine($"{currentKey}:");

                List<string> list = pair.Value;
                for (int index = 0; index < list.Count; index++)
                {
                    Console.WriteLine($"-{list[index]}");
                }
            }
        }
    }
}

//          IT IS NOT CORRECT -> 60/100
/*if(searchKey.Contains(key))
{

    for (int index = 0; index < valuesArray.Length; index++)
    {
        string searchValue = valuesArray[index];

        if(searchValue.Contains(value))
        {
            if (!pairs.ContainsKey(searchKey))
            {
                pairs.Add(searchKey, new List<string>());
            }
            pairs[searchKey].Add(searchValue);
        }                        
    }
}*/
