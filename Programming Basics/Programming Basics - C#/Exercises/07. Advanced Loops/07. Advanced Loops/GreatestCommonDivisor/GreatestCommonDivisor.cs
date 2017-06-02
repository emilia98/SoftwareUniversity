using System;

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main()
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            //SWAP THE BOTH VALUES, IF THE FIRST NUMBER IS SMALLER THAN THE SECOND
            if(a <= b)
            {
                int x;
                x = a;
                a = b;
                b = x;
            }

            /*Euclid's algorithm
               1) We have two numbers, the bigger will be divided byy the smaller
               2) First, we find the reminder of the both numbers
                  -> If the reminder = 0 => the GCD of (a,b) is a; -> we don't need a loop
                  -> Else, we need a loop, becuase we'll continue checking
               3) While the reminder is not 0, in the loop:
                  3.1) The first variable takes the value of the second;
                  3.2) The second variable takes the value of the reminder;
                  3.3) The new value of reminder is a result of modulo operation between the first and the second variable
               4) After the end of the loop, prints the last value of the second variable
            */
            c = a % b;

            while(c != 0)
            {
                a = b;
                b = c; 
                c = a % b;
            }
            Console.WriteLine(b);
        }
    }
}
