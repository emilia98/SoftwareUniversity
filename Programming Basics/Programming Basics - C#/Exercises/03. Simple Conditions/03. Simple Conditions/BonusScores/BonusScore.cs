using System;

namespace BonusScores
{
    class BonusScore
    {
        static void Main()
        {
            double score = double.Parse(Console.ReadLine());
            double bonus = 0;
            double result = 0;

            if (score <= 100)
            {
                bonus = 5;
            }
            else if (score > 100 && score <= 1000)
            {
                bonus = score * 0.2;
            }
            else if (score > 1000)                                // OR JUST ELSE WITHOUT IF
            {
                bonus = score * (double)10/100;
            }

            if (score % 2 == 0)
            {
                bonus += 1;
            }
            else if (score % 10 == 5)
            {
                bonus += 2;
            }

            result = score + bonus;

            Console.WriteLine(bonus);
            Console.WriteLine(result);
        }
    }
}
