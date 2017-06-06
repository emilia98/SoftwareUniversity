using System;

namespace _14.IntegerToHexAndBin_2
{
    class IntegerToHexAndBin_2
    {
        static void Main()
        {
            uint decimalNumber = uint.Parse(Console.ReadLine());

            string reversedHexNumber = String.Empty;
            uint number = decimalNumber;

            //Here we find the reversed hexadecimal number, because with the algorithm we have as a result the hexadecimal
            //number, but in reversed order.
            while(number != 0)
            {
                decimal divisionResult = (number * 1.0m) / 16;
                number = (uint)(divisionResult);
                uint numberToCheck = (uint)( (divisionResult - (uint)(divisionResult)) * 16);

                if(numberToCheck >= 0 && numberToCheck <= 9)
                {
                    reversedHexNumber += numberToCheck;
                }
                else if(numberToCheck == 10)
                {
                    reversedHexNumber += "A";
                }
                else if (numberToCheck == 11)
                {
                    reversedHexNumber += "B";
                }
                else if (numberToCheck == 12)
                {
                    reversedHexNumber += "C";
                }
                else if (numberToCheck == 13)
                {
                    reversedHexNumber += "D";
                }
                else if (numberToCheck == 14)
                {
                    reversedHexNumber += "E";
                }
                else
                { 
                    reversedHexNumber += "F";
                }           
            }

            //Here, we reverse the reversed hexadecimal number.
            //Firstly, we find the length of the number, we've found so far, and we print the number in
            //the correct order, symbol by symbol.
            for (int i = (reversedHexNumber.Length - 1); i >= 0; i--)
            {
                Console.Write(reversedHexNumber[i]);
            }
            Console.WriteLine();

            number = decimalNumber;
            string reversedBinNumber = String.Empty;

            //Here we find the reversed binary number, because with the algorithm we have as a result the binary
            //number, but in reversed order.
            while (number != 0)
            {
                uint reminder = (number % 2);
                number = number / 2;
                reversedBinNumber += reminder;
            }

            //Here, we reverse the reversed binary number.
            //Firstly, we find the length of the number, we've found so far, and we print the number in
            //the correct order, symbol by symbol.
            for (int i = (reversedBinNumber.Length - 1); i >= 0; i--)
            {
                Console.Write(reversedBinNumber[i]);
            }
            Console.WriteLine();
        }
    }
}

/*Algorithm:
  Decimal -> Hexadecimal
  number = 425;
  1) 425 / 16 = 26.5625
  2) 26.5625 - 26 = 0.5625     -> number = 26;   (int)(26.5625)
    3) 0.5625 * 16 = 9           -> 9
  4) 26 / 16 = 1.625
  5) 1.625 - 1 = 0.625         -> number = 1
    6) 0.625 * 16 = 10         -> 10 -> A
  7) 1 / 16 = 0.0625 
  8) 0.0625 - 0 = 0.0625       -> number = 0
    9) 0.0625 * 16 = 1         -> 1

    We've reached number = 0, so we exit from the loop.
  10) Now, we have a string, which conatains 9A1.
  11) We need to reverse the string, and we can do this with a loop.
  12) THE RESULT AT THE END IS:
      425(10) = 1AF(16)

 
  Decimal -> Binary
  number = 49;
    1) 49 % 2 = 1    -> 1
  2) 49 / 2 = 24     -> number = 24
    3) 24 % 2 = 0    -> 0
  4) 24 / 2 = 12     -> number = 12
    5) 12 % 2 = 0    -> 0
  6) 12 / 2 = 6      -> number = 6
    7) 6 % 2 = 0     -> 0
  8) 6 / 2 = 3       -> number = 3
    9) 3 % 2 = 1     -> 1
  10) 3 / 2 = 1      -> number = 1
    11) 1 % 2 = 1    -> 1
  12) 1 / 2 = 0      -> number = 0

      We've reached number = 0, so we exit from the loop.
     10) Now, we have a string, which conatains 100011.
  11) We need to reverse the string, and we can do this with a loop.
  12) THE RESULT AT THE END IS:
      49(10) = 110001(16)
           */
