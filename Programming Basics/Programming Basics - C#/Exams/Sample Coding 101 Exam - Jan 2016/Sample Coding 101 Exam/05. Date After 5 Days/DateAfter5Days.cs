using System;

namespace _05.Date_After_5_Days
{
    class DateAfter5Days
    {
        static void Main()
        {
            uint day = uint.Parse(Console.ReadLine());
            uint month = uint.Parse(Console.ReadLine());
            uint newDateDay, newDateMonth;

            if (month == 2)
            {
                if (day + 5 > 28)
                {
                    newDateDay = (day + 5) - 28;
                    newDateMonth = month + 1;
                }
                else
                {
                    newDateDay = day + 5;
                    newDateMonth = month;
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if (day + 5 > 30)
                {
                    newDateDay = (day + 5) - 30;
                    newDateMonth = month + 1;
                }
                else
                {
                    newDateDay = day + 5;
                    newDateMonth = month;
                }
            }
            else
            {
                ////If the month is NOT December and if we add 5 more days, the month of new date will be January
                if (day + 5 > 31 && month != 12)
                {
                    newDateDay = (day + 5) - 31;
                    newDateMonth = month + 1;
                }
                //If the month is December and if we add 5 more days, the month of new date will be January
                else if(day + 5 > 31 && month == 12)
                {
                    newDateDay = (day + 5) - 31;
                    newDateMonth = 1;
                }
                else
                {
                    newDateDay = day + 5;
                    newDateMonth = month;
                }
            }
            int leadingZeros = 2 - newDateMonth.ToString().Length;

            Console.Write("{0}.",newDateDay);
            Console.Write(new string('0', leadingZeros));
            Console.WriteLine("{0}", newDateMonth);
        }
    }
}
