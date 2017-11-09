using System;
using System.Linq;

namespace _05.RoundingNumbersAwayFromZero_3
{
    class RoundingNumbersAwayFromZero_3
    {
        static void Main()
        {        
            var array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int index = 0; index < array.Length; index++)
            {
                double number = array[index];
                double diff = Math.Abs(number - (int)number);

                if (diff >= 0.5)
                {
                    array[index] = array[index] > 0 ?
                                    (int)number + 1 : (int)number - 1;
                }
                else
                {
                    array[index] = (int)number;
                }
                Console.WriteLine("{0} => {1}", number, array[index]);
            }
        }
    }
}
