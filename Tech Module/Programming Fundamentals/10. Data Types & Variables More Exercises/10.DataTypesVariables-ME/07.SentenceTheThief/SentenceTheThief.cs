using System;

namespace _07.SentenceTheThief
{
    class SentenceTheThief
    {
        static void Main()
        {
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            //This is an array, which contains all the numbers from the input
            long[] currentNumber = new long[n];
            //Here we enter the first number, which value will be a default value of id
            currentNumber[0] = long.Parse(Console.ReadLine());
            long id = currentNumber[0];

            //Here we enter N - 1 numbers
            for (int i = 1; i < n; i++)
            {
                currentNumber[i] = long.Parse(Console.ReadLine());
            }

            //If the type is "long", we only find the biggest number. Finally, after we've found the biggest number,
            //we change the default value of id. The id variable now contains the biggestNumber value
            if (type == "long")
            {
                long biggestNumber = currentNumber[0];

                for (int i = 1; i < n; i++)
                {
                    if(currentNumber[i] >= biggestNumber)
                    {
                        biggestNumber = currentNumber[i];
                    }
                }
                id = biggestNumber;
                
            }

            /*If the type is "int", we:
                1) Have a new array, in which we'll store only the values, which are INT;
                2) After we've stored all of the INT values, we'll find the biggest INT value in the new array.
                3) Finally, after we've found the biggest number, we change the default value of id. 
                4) The id variable now contains the biggestNumber value
            */
            else if (type == "int")
            {
                long[] intNumbers = new long[n];
                int intCounter = 0;

                for (int i = 0; i < n; i++)
                {
                    if(currentNumber[i] >= int.MinValue && currentNumber[i] <= int.MaxValue)
                    {
                        intNumbers[intCounter] = currentNumber[i];
                        intCounter++;
                    }
                }

                long biggestNumber = intNumbers[0];
                
                for (int j = 1; j < intCounter; j++)
                {
                    if (intNumbers[j] >= biggestNumber)
                    {
                        biggestNumber = intNumbers[j];
                    }
                }
                id = biggestNumber;               
            }

            /*If the type is "sbyte", we:
               1) Have a new array, in which we'll store only the values, which are SBYTE;
               2) After we've stored all of the SBYTE values, we'll find the biggest SBYTE value in the new array.
               3) Finally, after we've found the biggest number, we change the default value of id. 
               4) The id variable now contains the biggestNumber value
           */
            else if (type == "sbyte")
            {
                long[] sByteNumbers = new long[n];
                int sByteCounter = 0;

                for (int i = 0; i < n; i++)
                {
                    if (currentNumber[i] >= sbyte.MinValue && currentNumber[i] <= sbyte.MaxValue)
                    {
                        sByteNumbers[sByteCounter] = currentNumber[i];
                        sByteCounter++;
                    }
                }

                long biggestNumber = sByteNumbers[0];
                for (int j = 1; j < sByteCounter; j++)
                {
                    if (sByteNumbers[j] >= biggestNumber)
                    {
                        biggestNumber = sByteNumbers[j];
                    }
                }

                id = biggestNumber;   
            }

            double yearsInPrison;

            if (id >= 0)
            {
                yearsInPrison = id * 1.0 / sbyte.MaxValue;
                yearsInPrison = Math.Ceiling(yearsInPrison);
            }
            else
            {
                yearsInPrison = id * 1.0 / sbyte.MinValue;
                yearsInPrison = Math.Ceiling(yearsInPrison);
            }

            if (yearsInPrison == 1)
            {
                Console.WriteLine("Prisoner with id {0} is sentenced to {1} year", id, yearsInPrison);
            }
            else
            {
                Console.WriteLine("Prisoner with id {0} is sentenced to {1} years", id, yearsInPrison);
            }
            
        }
    }
}
