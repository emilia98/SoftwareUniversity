using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FilterBase
{
    class FilterBase
    {
        static void Main()
        {
            string employee = Console.ReadLine();
            Dictionary<string, int> employeeByAge = new Dictionary<string, int>();
            Dictionary<string, double> employeeBySalary = new Dictionary<string, double>();
            Dictionary<string, string> employeeByPosition = new Dictionary<string, string>();

            StoreDataInDataBase(employee, ref employeeByAge, ref employeeBySalary, ref employeeByPosition);
            employee = Console.ReadLine();
            string filterBy = employee;

            if(filterBy == "Age")
            {
                FilterByAge(employeeByAge);
            }
            else if(filterBy == "Salary")
            {
                FilterBySalary(employeeBySalary);
            }
            else
            {
                FilterByPosition(employeeByPosition);
            }
        }

        static void StoreDataInDataBase(string employee, 
                                        ref Dictionary<string, int> employeeByAge,
                                        ref Dictionary<string, double> employeeBySalary,
                                        ref Dictionary<string, string> employeeByPosition)
        { 
            while (true)
            {
                if (employee == "filter base")
                {
                    break;
                }

                string[] splitInput = employee.Split(' ').ToArray();
                string name = splitInput[0];
                string secondValue = splitInput[2];

                int age;
                bool isInteger = int.TryParse(secondValue, out age);
                double salary;
                bool isFloatingPoint = double.TryParse(secondValue, out salary);

                if (isInteger)
                {
                    StoreEmployeeDataByAge(employeeByAge, name, age);
                }
                else if (isFloatingPoint)
                {
                    StoreEmployeeDataBySalary(employeeBySalary, name, salary);
                }
                else
                {
                    string position = secondValue;
                    StoreEmployeeDataByPosition(employeeByPosition, name, position);
                }
                employee = Console.ReadLine();
            }
        }

        static Dictionary<string, int> StoreEmployeeDataByAge(Dictionary<string, int> employeeByAge,
                                                              string name, int age)
        {
            if(!employeeByAge.ContainsKey(name))
            {
                employeeByAge.Add(name, age);
            }
            else
            {
                employeeByAge[name] = age;
            }
            return employeeByAge;
        }

        static Dictionary<string, double> StoreEmployeeDataBySalary(Dictionary<string, double> employeeBySalary,
                                                              string name, double salary)
        {
            if (!employeeBySalary.ContainsKey(name))
            {
                employeeBySalary.Add(name, salary);
            }
            else
            {
                employeeBySalary[name] = salary;
            }
            return employeeBySalary;
        }

        static Dictionary<string, string> StoreEmployeeDataByPosition(Dictionary<string, string> employeeByPosition,
                                                             string name, string position)
        {
            if (!employeeByPosition.ContainsKey(name))
            {
                employeeByPosition.Add(name, position);
            }
            else
            {
                employeeByPosition[name] = position;
            }
            return employeeByPosition;
        }

        static void FilterByAge(Dictionary<string,int> employeeByAge)
        {
            foreach(KeyValuePair<string,int> employee in employeeByAge)
            {
                Console.WriteLine("Name: {0}", employee.Key);
                Console.WriteLine("Age: {0}", employee.Value);
                Console.WriteLine(new string('=',20));
            }
        }

        static void FilterBySalary(Dictionary<string, double> employeeBySalary)
        {
            foreach (KeyValuePair<string, double> employee in employeeBySalary)
            {
                Console.WriteLine("Name: {0}", employee.Key);
                Console.WriteLine("Salary: {0:f2}", employee.Value);
                Console.WriteLine(new string('=', 20));
            }
        }

        static void FilterByPosition(Dictionary<string, string> employeeByPosition)
        {
            foreach (KeyValuePair<string, string> employee in employeeByPosition)
            {
                Console.WriteLine("Name: {0}", employee.Key);
                Console.WriteLine("Position: {0}", employee.Value);
                Console.WriteLine(new string('=', 20));
            }
        }
    }
}
