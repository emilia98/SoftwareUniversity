using System;

namespace _6.Stupid_Password_Generator
{
    class StupidPasswordGenerator
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            //If we want to count the number of combinations
            //int br = 0;

            for (int symb1 = 1; symb1 < n; symb1++)
            {
                for (int symb2 = 1; symb2 < n; symb2++)
                {
                    for (int symb3 = 97; symb3 < l + 97; symb3++)
                    {
                        for (int symb4 = 97; symb4 < l + 97; symb4++)
                        {
                            for (int symb5 = 2; symb5 <= n; symb5++)
                            {
                                if ((symb5 > symb1) && (symb5 > symb2))
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", symb1, symb2, (char)symb3, (char)symb4, symb5);
                                    //br++;
                                }
                            }
                        }
                    }
                }
            }
            //Console.WriteLine(br);
        }
    }
}
