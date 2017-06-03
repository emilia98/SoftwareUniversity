using System;

namespace _04.Elevator
{
    class Elevator
    {
        static void Main()
        {
            uint people = uint.Parse(Console.ReadLine());
            uint capacity = uint.Parse(Console.ReadLine());
            uint courses = (uint)(Math.Ceiling(people * 1.0 / capacity));
            Console.WriteLine(courses);
        }
    }
}
