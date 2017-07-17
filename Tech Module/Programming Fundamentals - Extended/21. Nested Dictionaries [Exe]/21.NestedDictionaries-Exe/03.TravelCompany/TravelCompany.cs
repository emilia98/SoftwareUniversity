using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TravelCompany
{
    class TravelCompany
    {
        static void Main()
        {
            /*Here, I create a nested dictionary, because I want to hold:
             - city, transport type, capacity of the transport type
             , beacuse I will manipulate the capacity - it could change
           */
            var cityAccomodation = new Dictionary<string, Dictionary<string, int>>();
            string command = Console.ReadLine();

            while (command != "ready")
            {
                char[] delimiter = { ':', ',' };
                string[] commandToArray = command.Split(delimiter).ToArray();
                string city = commandToArray[0];

                if (!cityAccomodation.ContainsKey(city))
                {
                    cityAccomodation.Add(city, new Dictionary<string, int>());
                }

                for (int index = 1; index < commandToArray.Length; index++)
                {
                    string[] transportAndCapacity = commandToArray[index].Split('-').ToArray();
                    string transport = transportAndCapacity[0];
                    int capacity = int.Parse(transportAndCapacity[1]);

                    if (!cityAccomodation[city].ContainsKey(transport))
                    {
                        cityAccomodation[city].Add(transport, capacity);
                    }
                    //If we already have that transport type, but with other capacity
                    cityAccomodation[city][transport] = capacity;
                }
                command = Console.ReadLine();
            }

            /*Here, I create a new dictionary, which will holds:
                - city and the capacity of all people we could transport to this city
            */
            var cityAndCapacity = new Dictionary<string, int>();

            foreach (var city in cityAccomodation)
            {
                string currentCity = city.Key;
                //Console.WriteLine($"{currentCity}:");
                int capacity = 0;
                Dictionary<string, int> transportAndCapacity = city.Value;

                foreach (var transport in transportAndCapacity)
                {
                    //Console.WriteLine($"{transport.Key} --> {transport.Value}");
                    // Here, we count the people we could transport to current city
                    capacity += transport.Value;
                }
                //We add the city and the capacity to the new created dictionary
                cityAndCapacity.Add(currentCity, capacity);
                //Console.WriteLine("Current city is {0} and capacity is {1}", currentCity, capacity);
            }
            command = Console.ReadLine();

            while (!command.Equals("travel time!"))
            {
                string[] commandSplit = command.Split(' ').ToArray();
                string city = commandSplit[0];
                int group = int.Parse(commandSplit[1]);

                if (group <= cityAndCapacity[city])
                {
                    int peopleToAccomodate = group;
                    Console.WriteLine("{0} -> all {1} accommodated", city, peopleToAccomodate);
                }
                else
                {
                    int peopleToAccomodate = group - cityAndCapacity[city];
                    Console.WriteLine("{0} -> all except {1} accommodated", city, peopleToAccomodate);
                }
                command = Console.ReadLine();
            }
        }
    }
}
