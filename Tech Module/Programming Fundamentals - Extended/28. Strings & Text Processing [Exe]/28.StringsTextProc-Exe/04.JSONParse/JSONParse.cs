using System;
using System.Collections.Generic;

namespace _04.JSONParse
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }

    class JSONParse
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var students = new List<Student>();
            input = input.Remove(0, 1);
            input = input.Remove(input.Length - 1, 1);

            string[] splitInput = input.Split(new[] { '{', '}'},
                                             StringSplitOptions.RemoveEmptyEntries);

            students = ParseTheStudentsData(splitInput, students);
            PrintTheStudents(students);
        }

        static void PrintTheStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                string name = student.Name;
                int age = student.Age;
                var grades = student.Grades;

                Console.Write("{0} : {1} -> ", name, age);
                if (grades.Count == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    Console.WriteLine("{0}", String.Join(", ", grades));
                }

            }
        }

        //Mazalo -> I wrote what I thought
        static List<Student> ParseTheStudentsData(string[] splitInput, List<Student> students)
        {
            foreach (var line in splitInput)
            {
                if (line != ",")
                {
                    string[] newStudent = line.Split(new string[] { "," },
                                                StringSplitOptions.RemoveEmptyEntries);
                    var name = newStudent[0].Substring(5);
                    name = name.Substring(1, name.Length - 2);

                    int age = int.Parse(newStudent[1].Substring(4));
                    var grades = new List<int>();

                    string gradesInput = String.Empty;
                    for (int index = 2; index < newStudent.Length; index++)
                    {
                        gradesInput += newStudent[index];
                    }

                    gradesInput = gradesInput.Substring(7);

                    if (gradesInput != "[]")
                    {
                        string[] gradesString = gradesInput.Split(new[] { '[', ']', ' ' },
                                                StringSplitOptions.RemoveEmptyEntries);
                        foreach (var grade in gradesString)
                        {
                            grades.Add(int.Parse(grade));
                        }
                    }

                    var student = new Student()
                    {
                        Name = name,
                        Age = age,
                        Grades = grades,
                    };
                    students.Add(student);
                }
            }
            return students;
        }
    }
}
