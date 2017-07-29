using System;
using System.Collections.Generic;

namespace _04.Websites
{
    class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }
    }

    class Websites
    {
        static void Main()
        {
            var newWebsites = new List<Website>();
            newWebsites = GetWebsites(newWebsites);
            PrintWebsites(newWebsites);
        }

        static List<Website> GetWebsites(List<Website> newWebsites)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] splitInput = input.Split(new string[] { " | ", "," },
                                                  StringSplitOptions.RemoveEmptyEntries);

                string host = splitInput[0];
                string domain = splitInput[1];
                var queries = new List<string>();
                queries = GetQueries(splitInput);

                var website = new Website()
                {
                    Host = host,
                    Domain = domain,
                    Queries = queries,
                };

                newWebsites.Add(website);
                input = Console.ReadLine();
            }
            return newWebsites;
        }

        static List<string> GetQueries(string[] splitInput)
        {
            var queries = new List<string>();

            for (int index = 2; index < splitInput.Length; index++)
            {
                queries.Add(splitInput[index]);
            }
            return queries;
        }

        static void PrintWebsites(List<Website> newWebsites)
        {
            foreach (var website in newWebsites)
            {
                string host = website.Host;
                string domain = website.Domain;
                var queriesList = website.Queries;

                if (queriesList.Count == 0)
                {
                    Console.WriteLine("https://www.{0}.{1}", host, domain);
                }
                else
                {
                    Console.Write("https://www.{0}.{1}/query?=", host, domain);

                    string queries = String.Empty;
                    for (int index = 0; index < queriesList.Count - 1; index++)
                    {
                        queries += $"[{queriesList[index]}]&";
                    }
                    queries += $"[{queriesList[queriesList.Count - 1]}]";
                    Console.WriteLine(queries);
                }
            }
        }
    }
}
