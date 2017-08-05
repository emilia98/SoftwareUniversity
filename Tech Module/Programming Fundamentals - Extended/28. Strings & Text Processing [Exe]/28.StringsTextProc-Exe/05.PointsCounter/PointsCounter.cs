using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PointsCounter
{
    class PointsCounter
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var teamData = new Dictionary<string, Dictionary<string, int>>();

            while (input != "Result")
            {
                string[] splitInput = input.Split('|');
                var firstWord = RemoveProhibitedSymbols(splitInput[0]);
                var secondWord = RemoveProhibitedSymbols(splitInput[1]);

                string team = String.Empty;
                string player = String.Empty;
                int points = int.Parse(splitInput[2]);

                if (firstWord.All(letter => Char.IsUpper(letter) == true))
                {
                    team = firstWord;
                    player = secondWord;
                }
                else
                {
                    team = secondWord;
                    player = firstWord;
                }

                if (!teamData.ContainsKey(team))
                {
                    teamData.Add(team, new Dictionary<string, int>());
                    teamData[team].Add(player, points);
                }
                else
                {
                    if(teamData[team].ContainsKey(player))
                    {
                        teamData[team][player] = points;
                    }
                    else
                    {
                        teamData[team].Add(player, points);
                    }
                }
                
                input = Console.ReadLine();
            }
            PrintTheResult(teamData);
        }

        static string RemoveProhibitedSymbols(string input)
        {
            var word = input.Replace("@", "");
            word = word.Replace("%", "");
            word = word.Replace("$", "");
            word = word.Replace("*", "");
            return word;
        }

        static void PrintTheResult(Dictionary<string, Dictionary<string,int>> teamData)
        {
            foreach (var team in teamData.OrderByDescending(x => x.Value.Values.Sum()))
            {
                string teamName = team.Key;
                var playerInfo = team.Value;
                Console.WriteLine("{0} => {1}", teamName, team.Value.Values.Sum());


                foreach (var player in playerInfo.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("Most points scored by {0}", player.Key);
                    break;
                }
            }
        }
    }
}
