using System;

namespace _4.Back_To_The_Past
{
    class BackToThePast
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            int yearsStay = year - 1800;
            double moneyNeeded = 0;

            for (int i = 0; i <= yearsStay; i++)
            {
                if (i % 2 == 0)
                {
                    moneyNeeded += 12000;
                }
                else
                {
                    moneyNeeded += 12000 + 50 * (18 + i);
                }
            }

            if (moneyNeeded <= money)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", money - moneyNeeded);
            }
            else
            {
                Console.WriteLine("He will need {0:0.00} dollars to survive.", moneyNeeded - money);
            }
        }
    }
}
