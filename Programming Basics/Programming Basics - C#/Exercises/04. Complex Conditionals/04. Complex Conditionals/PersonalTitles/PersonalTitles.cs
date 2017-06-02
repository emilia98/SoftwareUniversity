using System;

namespace PersonalTitles
{
    class PersonalTitles
    {
        static void Main()
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (gender == "m" || gender=="f")
            {
                if(age<16)
                {
                    if(gender == "m")
                    {
                        Console.WriteLine("Master");
                    }
                    else
                    {
                        Console.WriteLine("Miss");
                    }
                }
                else
                {
                    if (gender == "m")
                    {
                        Console.WriteLine("Mr.");
                    }
                    else
                    {
                        Console.WriteLine("Ms.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
            
        }
    }
}
