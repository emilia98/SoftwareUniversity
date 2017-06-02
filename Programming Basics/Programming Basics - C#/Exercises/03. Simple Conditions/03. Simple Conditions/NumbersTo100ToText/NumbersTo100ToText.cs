using System;

namespace NumbersTo100ToText
{
    class NumbersTo100ToText
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string numberToString = "";
            int dig1;
            int dig2;

            /*length could be found with:
               length = (number.ToString().Length);
            */
            if (number > 10 && number < 20)
            {
                if (number == 11)
                {
                    Console.WriteLine("eleven");
                }
                else if (number == 12)
                {
                    Console.WriteLine("twelve");
                }
                else if (number == 13)
                {
                    Console.WriteLine("thirteen");
                }
                else if (number == 14)
                {
                    Console.WriteLine("fourteen");
                }
                else if (number == 15)
                {
                    Console.WriteLine("fifteen");
                }
                else if (number == 16)
                {
                    Console.WriteLine("sixteen");
                }
                else if (number == 17)
                {
                    Console.WriteLine("seventeen");
                }
                else if (number == 18)
                {
                    Console.WriteLine("eighteen");
                }
                else
                {
                    Console.WriteLine("nineteen");
                }
            }

            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }

            else if (number >= 0 && number <= 10)
            {
                if (number == 0)
                {
                    Console.WriteLine("zero");
                }
                else if (number == 1)
                {
                    Console.WriteLine("one");
                }
                else if (number == 2)
                {
                    Console.WriteLine("two");
                }
                else if (number == 3)
                {
                    Console.WriteLine("three");
                }
                else if (number == 4)
                {
                    Console.WriteLine("four");
                }
                else if (number == 5)
                {
                    Console.WriteLine("five");
                }
                else if (number == 6)
                {
                    Console.WriteLine("six");
                }
                else if (number == 7)
                {
                    Console.WriteLine("seven");
                }
                else if (number == 8)
                {
                    Console.WriteLine("eight");
                }
                else if (number == 9)
                {
                    Console.WriteLine("nine");
                }
                else
                {
                    Console.WriteLine("ten");
                }
            }

            else if (number >= 20 && number <= 99)
            {
                /*
                    89  
                    -> dig1 = 8
                    -> dig2 = 9
                */
                dig1 = number / 10;
                dig2 = number % 10;

                //FOR FIRST DIGIT
                if (dig1 == 2)
                {
                    numberToString = "twenty";
                }
                else if (dig1 == 3)
                {
                    numberToString = "thirty";
                }
                else if (dig1 == 4)
                {
                    numberToString = "fourty";
                }
                else if (dig1 == 5)
                {
                    numberToString = "fifty";
                }
                else if (dig1 == 6)
                {
                    numberToString = "sixty";
                }
                else if (dig1 == 7)
                {
                    numberToString = "seventy";
                }
                else if (dig1 == 8)
                {
                    numberToString = "eighty";
                }
                else if (dig1 == 9)
                {
                    numberToString = "ninety";
                }

                //FOR SECOND DIGIT
                if (dig2 == 1)
                {
                    numberToString += " one";
                }
                else if (dig2 == 2)
                {
                    numberToString += " two";
                }
                else if (dig2 == 3)
                {
                    numberToString += " three";
                }
                else if (dig2 == 4)
                {
                    numberToString += " four";
                }
                else if (dig2 == 5)
                {
                    numberToString += " five";
                }
                else if (dig2 == 6)
                {
                    numberToString += " six";
                }
                else if (dig2 == 7)
                {
                    numberToString += " seven";
                }
                else if (dig2 == 8)
                {
                    numberToString += " eight";
                }
                else if (dig2 == 9)
                {
                    numberToString += " nine";
                }

                Console.WriteLine(numberToString);
            }

            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
