using System;

namespace _06.Heists
{
    class Heists
    {
        static void Main()
        {
            //input:
            var input = Console.ReadLine().Split(' ');

            int priceOfJewels = int.Parse(input[0]);
            int priceOfGold = int.Parse(input[1]);
            long totalMoney = 0;

            string heist = Console.ReadLine();

            while(heist != "Jail Time")
            {
                var splitHeist = heist.Split(' ');
                string loot = splitHeist[0];
                int expenses = int.Parse(splitHeist[1]);

                int jewelsCount = 0;
                int goldCount = 0;

                for (int index = 0; index < loot.Length; index++)
                {
                    if (loot[index] == '%')
                    {
                        jewelsCount++;
                    }
                    else if (loot[index] == '$')
                    {
                        goldCount++;
                    }                 
                }
                long earnings = (jewelsCount * priceOfJewels) + (goldCount * priceOfGold);
                totalMoney += (earnings - expenses);

                heist = Console.ReadLine();
            }

            if (totalMoney >= 0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalMoney}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(totalMoney)}.");
            }

            //goto input;
        }
    }
}
