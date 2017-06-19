using System;

namespace _07.NumbersToWords
{
    class NumbersToWords
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());

            string letterized = String.Empty;
            for (int i = 0; i < n; i++)
            {
                long number = long.Parse(Console.ReadLine());
                letterized = Letterize(number);
                if(letterized != String.Empty)
                {
                    Console.WriteLine(letterized);
                }
                
            }
            //Console.WriteLine(letterized);
        }

        static string Letterize(long number)
        {
            string result = String.Empty;

            if(number < 0 && Math.Abs(number) > 99)
            {
                result += "minus ";
            }

            if (number > 999)
            {
                result = "too large";
            }
            else if (number < -999)
            {
                result = "too small";
            }            
            else if (Math.Abs(number) >= 100 && Math.Abs(number) <= 999)
            {
                number = Math.Abs(number); 
                long digit1 = number / 100;
                long digit2 = (number / 10) % 10;
                long digit3 = number % 10;

                result += FromOneToNine(digit1);
                result += "-hundred";

                if(digit2 == 0 && digit3 != 0)
                {
                    result += " and ";
                    result += FromOneToNine(digit3);
                }
                else if(digit2 == 1)
                {
                    switch (digit3)
                    {
                        case 1:
                            {
                                result += " and eleven";
                                break;
                            }
                        case 2:
                            {
                                result += " and twelve";
                                break;
                            }
                        case 3:
                            {
                                result += " and thirteen";
                                break;
                            }
                        case 4:
                            {
                                result += " and fourteen";
                                break;
                            }
                        case 5:
                            {
                                result += " and fifteen";
                                break;
                            }
                        case 6:
                            {
                                result += " and sixteen";
                                break;
                            }
                        case 7:
                            {
                                result += " and seventeen";
                                break;
                            }
                        case 8:
                            {
                                result += " and eighteen";
                                break;
                            }
                        case 9:
                            {
                                result += " and nineteen";
                                break;
                            }
                        case 0:
                            {
                                result += " and ten";
                                break;
                            }
                    }
                }
                else if(digit2 > 1)
                {
                    switch (digit2)
                    {
                        case 2:
                            {
                                result += " and twenty ";
                                break;
                            }
                        case 3:
                            {
                                result += " and thirty ";
                                break;
                            }
                        case 4:
                            {
                                result += " and forty ";
                                break;
                            }
                        case 5:
                            {
                                result += " and fifty ";
                                break;
                            }
                        case 6:
                            {
                                result += " and sixty ";
                                break;
                            }
                        case 7:
                            {
                                result += " and seventy ";
                                break;
                            }
                        case 8:
                            {
                                result += " and eighty ";
                                break;
                            }
                        case 9:
                            {
                                result += " and ninety ";
                                break;
                            }                      
                    }
                    
                    if(digit3 != 0)
                    {
                        result += FromOneToNine(digit3);
                    }
                }
            }
            return result;
        }
        
        static string FromOneToNine(long digit)
        {
            string result = String.Empty;
            switch (digit)
            {
                case 1:
                    {
                        result += "one";
                        break;
                    }
                case 2:
                    {
                        result += "two";
                        break;
                    }
                case 3:
                    {
                        result += "three";
                        break;
                    }
                case 4:
                    {
                        result += "four";
                        break;
                    }
                case 5:
                    {
                        result += "five";
                        break;
                    }
                case 6:
                    {
                        result += "six";
                        break;
                    }
                case 7:
                    {
                        result += "seven";
                        break;
                    }
                case 8:
                    {
                        result += "eight";
                        break;
                    }
                case 9:
                    {
                        result += "nine";
                        break;
                    }
            }
            return result;
        }
    }
}
