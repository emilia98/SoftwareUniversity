using System;

namespace _01.CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        static void Main()
        {
            Console.Write("Centuries = ");
            ushort centuries = ushort.Parse(Console.ReadLine());
            uint years = (uint)(centuries * 100);
            uint days = (uint)(years * 365.2422);
            ulong hours = days * 24;
            ulong minutes = hours * 60;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", 
                centuries, years, days, hours, minutes);          
        }
    }
}
