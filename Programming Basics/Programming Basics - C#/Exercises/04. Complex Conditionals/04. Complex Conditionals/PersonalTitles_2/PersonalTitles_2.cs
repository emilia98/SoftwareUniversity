using System;

namespace PersonalTitles_2
{
    class PersonalTitles_2
    {
        static void Main()
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            string output = "Invalid.";

            if (gender == "m")
            {
                 if (age < 16)
                 {
                     output = "Master";
                 }
                 else
                 {
                     output = "Mr.";
                 }
            }
            else
            {
                 if (age < 16)
                 {
                    output = "Miss";
                 }
                 else
                 {
                    output = "Ms.";
                 }
            }
            Console.WriteLine(output);

        }
    }
}
