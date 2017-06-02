using System;
using System.Globalization;

namespace _1000DaysOnEarth
{
    class OnEarth1000Days
    {
        static void Main()
        {
            //string birthDateSTR = Console.ReadLine();

            DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime daysAfterBirth = birthDate.AddDays(999);
            Console.WriteLine(daysAfterBirth.ToString("dd-MM-yyyy"));
        }
    }
}
