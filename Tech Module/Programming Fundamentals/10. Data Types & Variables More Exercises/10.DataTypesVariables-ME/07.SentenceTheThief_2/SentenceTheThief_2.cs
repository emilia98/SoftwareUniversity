using System;

namespace _07.SentenceTheThief_2
{
    class SentenceTheThief_2
    {
        static void Main()
        {
            string type = Console.ReadLine();
            long maxValue = 0L;

            switch (type)
            {
                case "sbyte":
                    {
                        maxValue = sbyte.MaxValue;
                        break;
                    }
                case "int":
                    {
                        maxValue = int.MaxValue;
                        break;
                    }
                case "long":
                    {
                        maxValue = long.MaxValue;
                        break;
                    }
            }

            uint n = uint.Parse(Console.ReadLine());
            long id = long.MinValue;

            for (uint i = 0; i < n; i++)
            {
                long currentNumber = long.Parse(Console.ReadLine());

                if (currentNumber > id && currentNumber <= maxValue)
                {
                    id = currentNumber;
                }
            }

            double number = 0;

            if (id >= 0)
            {
                number = sbyte.MaxValue;
            }
            else
            {
                number = sbyte.MinValue;
            }
            double yearsInPrison = Math.Ceiling(id / number);
            Console.WriteLine("Prisoner with id {0} is sentenced to {1} {2}",
                                id,
                                yearsInPrison,
                                yearsInPrison == 1 ? "year" : "years");
        }
    }
}
