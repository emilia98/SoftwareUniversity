using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Wardrobe
{
    class Wardrobe
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> clothesData = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < n; cnt++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " -> " },
                                                          StringSplitOptions.None).ToArray();
                string color = input[0];
                string[] clothesToAdd = input[1].Split(',').ToArray();

                if(!clothesData.ContainsKey(color))
                {
                    clothesData.Add(color, new Dictionary<string, int>());
                }
                for (int index = 0; index < clothesToAdd.Length; index++)
                {
                    string clothesType = clothesToAdd[index];

                    if(!clothesData[color].ContainsKey(clothesType))
                    {
                        clothesData[color].Add(clothesType, 1);
                    }
                    else
                    {
                        clothesData[color][clothesType] += 1;
                    }
                }                
            }

            string[] itemToFind = Console.ReadLine().Split(' ').ToArray();
            string itemToFindColor = itemToFind[0];
            string itemToFindType = itemToFind[1];

            /*  Doesn't work correctly
             *  Here, we form a string, in case we have a dress with more than one word
            string itemToFindType = String.Empty;
            for (int index = 1; index < itemToFind.Length; index++)
            {
                itemToFindType += itemToFind[index] + " ";
            }
               Remove the space in the end, because int the check below, we won't have the right result
            itemToFindType = itemToFindType.Remove(itemToFindType.Length - 1)*/

            foreach (var color in clothesData)
            {
                string clothesColor = color.Key;
                Dictionary<string, int> clothesType = color.Value;
                Console.WriteLine("{0} clothes:", clothesColor);

                foreach (var clothes in clothesType)
                {
                    string clothingItem = clothes.Key;
                    int clothingCount = clothes.Value;

                    if (clothesColor == itemToFindColor && clothingItem == itemToFindType)
                    {
                        Console.WriteLine("* {0} - {1} (found!)", clothingItem, clothingCount);
                    }
                    else
                    {
                        Console.WriteLine("* {0} - {1}", clothingItem, clothingCount);
                    }
                }
            }
        }
    }
}
