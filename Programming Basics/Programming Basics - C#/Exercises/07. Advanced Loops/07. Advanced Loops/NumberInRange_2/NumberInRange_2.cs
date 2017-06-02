using System;

namespace NumberInRange_2
{
    class NumberInRange_2
    {
        static void Main()
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            int number = int.Parse(Console.ReadLine());

            while (number < 1 || number > 100)  // OR while(!(number>=1 && number<=100))
            {
                Console.WriteLine("Invalid number!");

                Console.Write("Еnter a number in the range [1...100]: ");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}",number);
        }
    }
}
