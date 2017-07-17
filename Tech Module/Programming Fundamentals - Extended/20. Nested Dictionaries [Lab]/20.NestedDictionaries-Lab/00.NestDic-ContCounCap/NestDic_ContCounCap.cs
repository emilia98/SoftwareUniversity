using System;
using System.Collections.Generic;
using System.Linq;

namespace _00.NestDic_ContCounCap
{
    class NestDic_ContCounCap
    {
        static void Main()
        {
            var continentsData = new Dictionary<string, Dictionary<string, string>>();
            int inputCnt = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < inputCnt; cnt++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string continentName = input[0];
                string countryName = input[1];
                string capitalName = input[2];

                if(!continentsData.ContainsKey(continentName))
                {
                    continentsData.Add(continentName, new Dictionary<string, string>());
                }
                continentsData[continentName].Add(countryName, capitalName);
            }

            foreach(var record in continentsData)
            {
                string continentName = record.Key;
                Dictionary<string, string> countryData = record.Value;
                Console.WriteLine("{0}: ", continentName);
                foreach(KeyValuePair<string, string> country in countryData)
                {
                    string countryName = country.Key;
                    string capitalName = country.Value;
                    Console.WriteLine(" {0} --> {1}", countryName, capitalName);
                }
            }
        }
    }
}
/*
    Input:
    6
    Asia Japan Tokyo
    Europe Bulgaria Sofia
    Europe UK London
    Asia China Beijing
    North_America USA Washington
    North_America Canada Otawa

    Output:
    Asia:
     Japan --> Tokyo
     China --> Beijing
    Europe:
     Bulgaria --> Sofia
     UK --> London
    North_America:
     USA --> Washington
     Canada --> Otawa
 * */

