using System;

namespace _14.MagicLetter
{
    class MagicLetter
    {
        static void Main()
        {
            char let1 = char.Parse(Console.ReadLine());
            char let2 = char.Parse(Console.ReadLine());
            char let3 = char.Parse(Console.ReadLine());

            for (char i = let1; i <= let2; i++)
            {
                for (char j = let1; j <= let2; j++)
                {
                    for (char k = let1; k <= let2; k++)
                    {
                        if(i != let3 && j != let3 && k != let3)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
