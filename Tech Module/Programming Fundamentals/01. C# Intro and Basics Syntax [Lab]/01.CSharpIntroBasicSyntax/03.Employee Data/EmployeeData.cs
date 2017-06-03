﻿using System;

namespace _03.Employee_Data
{
    class EmployeeData
    {
        static void Main()
        {
            string name = Console.ReadLine();
            short age = short.Parse(Console.ReadLine());
            long id = long.Parse(Console.ReadLine());
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}",name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Employee ID: {0:D8}", id);
            Console.WriteLine("Salary: {0:f2}", salary);
        }
    }
}
