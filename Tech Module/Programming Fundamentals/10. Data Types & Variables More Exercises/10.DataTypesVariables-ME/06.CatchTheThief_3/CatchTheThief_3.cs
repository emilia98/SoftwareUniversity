using System;

namespace _06.CatchTheThief_3
{
    class CatchTheThief_3
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

                if(currentNumber > id && currentNumber <= maxValue )
                {
                    id = currentNumber;
                }
            }
            Console.WriteLine(id);
        }
    }
}
