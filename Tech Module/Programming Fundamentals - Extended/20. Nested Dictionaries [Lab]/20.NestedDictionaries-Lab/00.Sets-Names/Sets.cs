using System;
using System.Collections.Generic;

namespace _00.Sets_Names
{
    class Sets
    {
        static void Main()
        {
            HashSet<string> names = new HashSet<string>();

            names.Add("Pesho");
            names.Add("Acho");
            names.Add("Tosho");
            names.Add("Pesho");
            names.Add("Maria");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(new string('-', 25));
            SortedSet<int> numbers = new SortedSet<int>();

            numbers.Add(5);
            numbers.Add(232);
            numbers.Add(10);
            numbers.Add(1);
            numbers.Add(843);

            Console.WriteLine("Before: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Remove(5);
            numbers.Add(25);
            numbers.Remove(843);
            numbers.Add(17);
            Console.WriteLine("After: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
