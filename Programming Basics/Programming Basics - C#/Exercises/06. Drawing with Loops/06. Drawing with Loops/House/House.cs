using System;

namespace House
{
    class House
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int dashes;
            int stars = 1;

            if (n == 2)
            {
                Console.WriteLine("**");
                Console.WriteLine("||");
            }
            else
            {
                if (n % 2 == 0)
                {
                    stars = 2;
                }
                //dashes = n - stars;

                for (int i = 1; i <= n; i++)
                {
                    dashes = n - stars;

                    //This If is our ROOF
                    if (stars <= n)
                    {
                        if (dashes > 0)
                        {
                            Console.Write(new string('-', dashes / 2));
                            Console.Write(new string('*', stars));
                            Console.Write(new string('-', dashes / 2));
                        }
                        else
                        {
                            Console.Write(new string('*', stars));
                        }
                        stars += 2;
                    }
                    // This Else is our GROUNDWORK
                    else
                    {
                        Console.Write("|");
                        Console.Write(new string('*', n - 2));
                        Console.Write("|");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
