﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Exercises
{
    class Exercises_P
    {
        class Exercises
        {
            public string Topic { get; set; }
            public string CourseName { get; set; }
            public string JudgeContestLink { get; set; }
            public List<string> Problems { get; set; }
        }

        static void Main()
        {
            var newExercises = new List<Exercises>();
            newExercises = GetExercises(newExercises);
            PrintExercises(newExercises);
        }

        static List<Exercises> GetExercises(List<Exercises> newExercises)
        {
            string input = Console.ReadLine();

            while (input != "go go go")
            {
                string[] splitInput = input.Split(new string[] { " -> ", ", " },
                                                  StringSplitOptions.RemoveEmptyEntries);

                var adding = new Exercises()
                {
                    Topic = splitInput[0],
                    CourseName = splitInput[1],
                    JudgeContestLink = splitInput[2],
                    Problems = splitInput.Skip(3).ToList(),
                };
                newExercises.Add(adding);
                input = Console.ReadLine();
            }
            return newExercises;
        }

        static void PrintExercises(List<Exercises> newExercises)
        {
            for (int index = 0; index < newExercises.Count; index++)
            {
                string topic = newExercises[index].Topic;
                string courseName = newExercises[index].CourseName;
                string judgeLink = newExercises[index].JudgeContestLink;
                List<string> problems = newExercises[index].Problems;

                Console.WriteLine($"Exercises: {topic}");
                Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.",
                                  courseName);
                Console.WriteLine("Check your solutions here: {0}", judgeLink);

                int pos = 1;
                foreach (string problem in problems)
                {
                    Console.WriteLine("{0}. {1}", pos, problem);
                    pos++;
                }
            }
        }
    }
}
