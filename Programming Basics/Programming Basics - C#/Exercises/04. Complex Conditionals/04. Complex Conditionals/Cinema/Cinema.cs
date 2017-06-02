using System;

namespace Cinema
{
    class Cinema
    {
        static void Main()
        {
            string typeProjection = Console.ReadLine().ToLower();
            uint r = uint.Parse(Console.ReadLine());
            uint c = uint.Parse(Console.ReadLine());
            double incomes = 0;

            if(typeProjection == "premiere")
            {
                incomes = r * c * 12.00;
            }
            else if(typeProjection == "normal")
            {
                incomes = r * c * 7.50;
            }
            else if(typeProjection == "discount")
            {
                incomes = r * c * 5.00;
            }
            Console.WriteLine("{0:f2}",incomes);
        }
    }
}
