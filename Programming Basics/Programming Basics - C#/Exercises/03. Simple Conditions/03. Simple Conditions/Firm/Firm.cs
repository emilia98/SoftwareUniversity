using System;

namespace Firm
{
    class Firm
    {
        static void Main()
        {
            uint hoursNeeded = uint.Parse(Console.ReadLine());
            uint days = uint.Parse(Console.ReadLine());
            uint employees = uint.Parse(Console.ReadLine());

            uint workHours = days * 8;
            double hoursAfterTeamBuildings = workHours - workHours * 0.1; // hoursLeft --> hours left after trainings and courses 10%
            double extraordinaryHours = 2 * employees * days;

            double allHours = hoursAfterTeamBuildings + extraordinaryHours;
            allHours = Math.Floor(allHours);

            if(allHours >= hoursNeeded)
            {
                double hoursLeft = allHours - hoursNeeded;
                Console.WriteLine("Yes!{0} hours left.",hoursLeft);        
            }
            else
            {
                double hoursMore = hoursNeeded - allHours;
                Console.WriteLine("Not enough time!{0} hours needed.",hoursMore);
            }
        }
    }
}
