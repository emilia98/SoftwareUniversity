using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.JSONStringify
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }

    class JSONStringify
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var studentsList = new List<Student>();

            while (input != "stringify")
            {
                char[] delimiter = { ' ', '-', '>', ',', ':'};
                string[] splitInput = input.Split(delimiter,
                                       StringSplitOptions.RemoveEmptyEntries);

                var student = GetGrades(splitInput);

                studentsList.Add(student);
                input = Console.ReadLine();
            }
            PrintTheResult(studentsList);
            Console.WriteLine();
        }

        static void PrintTheResult(List<Student> studentsList)
        {
            Console.Write("[");
            for (int index = 0; index < studentsList.Count; index++)
            {
                string name = studentsList[index].Name;
                int age = studentsList[index].Age;
                var grades = studentsList[index].Grades;

                Console.Write("{3}name:\"{0}\",age:{1},grades:[{2}]{4}",
                                   name, age,
                                   String.Join(", ", grades), '{', '}');

                if (index != studentsList.Count - 1 )
                {
                    Console.Write(",");
                }                
            }
            Console.Write("]");         
        }

        static Student GetGrades(string[] splitInput)
        {
            Student student;

            student = new Student()
            {
                Name = splitInput[0],
                Age = int.Parse(splitInput[1]),
                Grades = splitInput.Skip(2).Select(int.Parse).ToList()
            };
            return student;
        }
    }
}
