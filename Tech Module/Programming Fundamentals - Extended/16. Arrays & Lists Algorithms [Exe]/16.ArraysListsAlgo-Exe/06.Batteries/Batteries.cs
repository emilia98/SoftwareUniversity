using System;
using System.Linq;

namespace _06.Batteries
{
    class Batteries
    {
        static void Main()
        {
            double[] capacity = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int hoursToStress = int.Parse(Console.ReadLine());

            GetAResult(capacity, usagePerHour, hoursToStress);
        }

        static void GetAResult(double[] capacity, double[] usagePerHour, int hoursToStress)
        {
            for (int index = 0; index < capacity.Length; index++)
            {
                int hoursLeft = hoursToStress;
                int hoursLasted = 0;
                double batteryCapacity = capacity[index];
                double batteryUsage = usagePerHour[index];
                string result = String.Empty;

                while (hoursLeft > 0 && batteryCapacity > 0)
                {
                    batteryCapacity -= batteryUsage;
                    hoursLeft--;
                    hoursLasted++;
                }

                result = $"Battery {index + 1}: ";
                if (batteryCapacity < 0)
                {
                    result += $"dead (lasted {hoursLasted} hours)";
                }
                else
                {
                    double percent = batteryCapacity * 100.0 / capacity[index];
                    result += $"{batteryCapacity:f2} mAh ({percent:f2})%";
                }
                Console.WriteLine(result);
            }
        }
    }
}
