//Both solutions are correct
using System;

namespace InvalidNumber
{
    class InvalidNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            /*if((number>=100 && number<=200) || number == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("invalid");
            }*/
            if ((number < 100 || number > 200) && number != 0)
            {
                Console.WriteLine("invalid"); 
            }
            else
            {
               Console.WriteLine();
            }
        }
    }
}
