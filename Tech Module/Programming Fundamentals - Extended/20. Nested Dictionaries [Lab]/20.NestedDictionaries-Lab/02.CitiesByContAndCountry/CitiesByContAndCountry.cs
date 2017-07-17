using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CitiesByContAndCountry
{
    class CitiesByContAndCountry
    {
        static void Main()
        {
            var continentData = new Dictionary<string, Dictionary<string, List<string>>>();
            int inputCnt = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < inputCnt; cnt++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if(!continentData.ContainsKey(continent))
                {
                    continentData.Add(continent, new Dictionary<string, List<string>>());
                    continentData[continent].Add(country, new List<string>());
                    continentData[continent][country].Add(city);
                }
                else
                {
                    if (!continentData[continent].ContainsKey(country))
                    {
                        continentData[continent].Add(country, new List<string>());
                    }                    
                    continentData[continent][country].Add(city);
                }               
            }

            foreach(KeyValuePair<string, Dictionary<string, List<string>>> continent in continentData)
            {
                string currentContinent = continent.Key;
                Dictionary<string, List<string>> countryData = continent.Value;
                Console.WriteLine("{0}: ", currentContinent);

                foreach(KeyValuePair<string,List<string>> country in countryData)
                {
                    string currentCountry = country.Key;
                    List<string> cities = country.Value;
                    Console.WriteLine(" {0} -> {1}", currentCountry, 
                                                     String.Join(", ", cities));
                }
            }
        }
    }
}
