using System;
using System.Numerics;

namespace _10.CenturiesToNanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main()
        {
            ushort centuries = ushort.Parse(Console.ReadLine());
            uint years = (uint)(centuries * 100);
            uint days = (uint)(years * 365.2422);
            uint hours = (uint)(days * 24);
            ulong minutes = (ulong)(hours * 60);
            ulong seconds = (ulong)(minutes * 60);
            ulong milliseconds = (ulong)(seconds * 1000);
            BigInteger microseconds = (BigInteger)(milliseconds * 1000);
            BigInteger nanoseconds = (BigInteger)(microseconds * 1000);
            //decimal nanoseconds = (decimal)(microseconds * 1000);

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                              centuries, years,days, hours, minutes, seconds,milliseconds,microseconds,nanoseconds);
        }
    }
}
