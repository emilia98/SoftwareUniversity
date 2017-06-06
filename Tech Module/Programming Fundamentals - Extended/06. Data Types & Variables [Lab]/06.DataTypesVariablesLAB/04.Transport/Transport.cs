using System;

namespace _04.Transport
{
    class Transport
    {
        static void Main()
        {
            uint people = uint.Parse(Console.ReadLine());
            uint capacity = 4 + 8 + 12;
            uint courses = (uint)(Math.Ceiling(people * 1.0 / capacity));

            Console.WriteLine(courses);
        }
    }
}
