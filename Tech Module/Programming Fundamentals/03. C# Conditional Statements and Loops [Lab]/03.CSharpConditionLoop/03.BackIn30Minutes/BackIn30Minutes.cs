using System;

namespace _03.BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main()
        {
            sbyte hours = sbyte.Parse(Console.ReadLine());
            sbyte minutes = sbyte.Parse(Console.ReadLine());

            if(minutes >= 30)
            {
                if(hours >= 23)
                {
                    hours -= 23;
                }
                else
                {
                    hours += 1;
                }       
                minutes -= 30;
            }
            else
            {
                minutes += 30;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
