using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GroupInAlphabetOrder
{
    class GroupInAlphabeticalOrder
    {
        static void Main()
        {
            var continentData = new SortedDictionary<string, 
                                                     SortedDictionary<string, SortedSet<string>>>();
            int inputCnt = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < inputCnt; cnt++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if(!continentData.ContainsKey(continent))
                {
                    continentData.Add(continent, new SortedDictionary<string, SortedSet<string>>());
                    continentData[continent].Add(country, new SortedSet<string>());
                    continentData[continent][country].Add(city);
                }
                else
                {
                    if(!continentData[continent].ContainsKey(country))
                    {
                        continentData[continent].Add(country, new SortedSet<string>());
                    }
                    continentData[continent][country].Add(city);
                }             
            }

            foreach(var continent in continentData)
            {
                string currentContinent = continent.Key;
                Console.WriteLine("{0}: ", currentContinent);

                SortedDictionary<string, SortedSet<string>> countryData = continent.Value ;
                foreach (var country in countryData)
                {
                    string currentCountry = country.Key;
                    SortedSet<string> cities = country.Value;
                    Console.WriteLine(" {0} -> {1}", currentCountry, 
                                                    String.Join(", ", cities));
                }
            }
        }
    }
}
