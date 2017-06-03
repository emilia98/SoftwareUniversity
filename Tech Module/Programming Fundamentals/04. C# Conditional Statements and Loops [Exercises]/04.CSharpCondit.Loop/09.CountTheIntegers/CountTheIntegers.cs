using System;

namespace _09.CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main()
        {
            bool isNumber;
            int counter = 0;
            int number;
            string text = Console.ReadLine();
            
            isNumber = int.TryParse(text, out number);

            while(isNumber == true)
            {
                counter++;
                text = Console.ReadLine();
                isNumber = int.TryParse(text, out number);
            }

            Console.WriteLine(counter);
        }
    }
}
