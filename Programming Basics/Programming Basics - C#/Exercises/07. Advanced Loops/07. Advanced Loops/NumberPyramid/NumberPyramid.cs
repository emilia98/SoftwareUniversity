using System;

namespace NumberPyramid
{
    class NumberPyramid
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int firstNumber = 1, numberCount = 2;

            Console.WriteLine(firstNumber);
            firstNumber += 1;

            while(numberCount <= n)
            {
                if (firstNumber == n)
                {
                    Console.WriteLine(firstNumber);
                    break;
                }
                int j = 1;

                while(j <= numberCount && firstNumber!=n)
                {
                    
                    if(j != numberCount)
                    {
                        Console.Write("{0} ", firstNumber);
                    }
                    else
                    {
                        Console.WriteLine("{0} ", firstNumber);
                    }
                    
                    firstNumber++;
                    j++;
                }
                numberCount++;
                
            }
           
        }
    }
}
