//Preslav Mihaylov's solution, completed by me --> TOO LONG, BUT CORRECT
using System;

namespace NumbersTo100ToText_2
{
    class NumbersTo100ToText_2
    {
        static void Main()
        {
            string firstWord = "";
            string secondWord = "";
            int number = int.Parse(Console.ReadLine());

            bool isValid = true;
            if (number < 0)
            {
                isValid = false;
            }

            int units = number % 10;  //edinici
            number = number / 10;
            int tens = number % 10; //desetici
            number = number / 10;
            int hundreds = number % 10; //stotici

            if (hundreds == 0 && isValid)
            {
                if(units == 0)
                {
                    secondWord = "";
                }
                if (units == 1)
                {
                    secondWord = "one";
                }
                else if (units == 2)
                {
                    secondWord = "two";
                }
                else if (units == 3)
                {
                    secondWord = "three";
                }
                else if (units == 4)
                {
                    secondWord = "four";
                }
                else if (units == 5)
                {
                    secondWord = "five";
                }
                else if (units == 6)
                {
                    secondWord = "six";
                }
                else if (units == 7)
                {
                    secondWord = "seven";
                }
                else if (units == 8)
                {
                    secondWord = "eight";
                }
                else if (units == 9)
                {
                    secondWord = "nine";
                }

                if(tens == 0)
                {
                    if(units==0)
                    {
                        secondWord = "zero";
                    }
                }
                else if (tens == 1)
                {
                    secondWord = "";
                    if (units == 0)
                    {
                        firstWord = "ten";
                    }
                    else if (units == 1)
                    {
                        firstWord = "eleven";
                    }
                    else if (units == 2)
                    {
                        firstWord = "twelve";
                    }
                    else if (units == 3)
                    {
                        firstWord = "thirteen";
                    }
                    else if (units == 4)
                    {
                        firstWord = "fourteen";
                    }
                    else if (units == 5)
                    {
                        firstWord = "fifteen";
                    }
                    else if (units == 6)
                    {
                        firstWord = "sixteen";
                    }
                    else if (units == 7)
                    {
                        firstWord = "seventeen";
                    }
                    else if (units == 8)
                    {
                        firstWord = "eighteen";
                    }
                    else if (units == 9)
                    {
                        firstWord = "nineteen";
                    }
                }
                if (tens == 2)
                {
                    firstWord = "twenty";
                }
                else if (tens == 3)
                {
                    firstWord = "thirty";
                }
                else if (tens == 4)
                {
                    firstWord = "fourty";
                }
                else if (tens == 5)
                {
                    firstWord = "fifty";
                }
                else if (tens == 6)
                {
                    firstWord = "sixty";
                }
                else if (tens == 7)
                {
                    firstWord = "seventy";
                }
                else if (tens == 8)
                {
                    firstWord = "eighty";
                }
                else if (tens == 9)
                {
                    firstWord = "ninety";
                }

                if(secondWord == "")
                {
                    Console.WriteLine(firstWord);
                }
                else if(firstWord == "")
                {
                    Console.WriteLine(secondWord);
                }
                else
                {
                    Console.WriteLine("{0} {1}", firstWord, secondWord);
                }
                
            }
            else if ((hundreds == 1 && (units == 0 && tens == 0)) && isValid)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                Console.WriteLine("invalid number");
            }
            
        }
    }
}
