using System;

namespace _08.EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            ulong personalID = ulong.Parse(Console.ReadLine());
            uint uniqueNumber = uint.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}\nLast name: {lastName}");
            Console.WriteLine($"Age: {age}\nGender: {gender}");
            Console.WriteLine($"Personal ID: {personalID}\nUnique Employee number: {uniqueNumber}");
        }
    }
}
