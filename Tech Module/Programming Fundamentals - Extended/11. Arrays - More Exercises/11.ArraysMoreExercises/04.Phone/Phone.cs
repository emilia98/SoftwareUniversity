using System;

namespace _04.Phone
{
    class Phone
    {
        static void Main()
        {
            string inputNumbers = Console.ReadLine();
            string inputNames = Console.ReadLine();

            string[] numbers = inputNumbers.Split(' ');
            string[] names = inputNames.Split(' ');

            string currentString = String.Empty;

            while(currentString != "done")
            {
                currentString = Console.ReadLine();
                string[] commands = currentString.Split(' ');

                if(commands[0] == "call")
                {
                    string calling = String.Empty;
                    string resultOfCall = String.Empty;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (commands[1] == numbers[i])
                        {
                            calling = $"calling {names[i]}...";
                            long sum = SumDigits(numbers[i]);
                            resultOfCall = GetAResultOfCall(sum);
                            break;
                        }
                        else if(commands[1] == names[i])
                        {
                            calling = $"calling {numbers[i]}...";
                            long sum = SumDigits(numbers[i]);
                            resultOfCall = GetAResultOfCall(sum);
                            break;
                        }
                    }
                    Console.WriteLine(calling);
                    Console.WriteLine(resultOfCall);
                    
                }
                else if(commands[0] == "message")
                {
                    string sending = String.Empty;
                    string resultOfMessage = String.Empty;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (commands[1] == numbers[i])
                        {
                            sending = $"sending sms to {names[i]}...";
                            long difference = SubstractDigits(numbers[i]);
                            resultOfMessage = GetAResultOfMessage(difference);
                            break;
                        }
                        else if (commands[1] == names[i])
                        {
                            sending = $"sending sms to {numbers[i]}...";
                            long difference = SubstractDigits(numbers[i]);
                            resultOfMessage = GetAResultOfMessage(difference);
                            break;
                        }
                    }
                    Console.WriteLine(sending);
                    Console.WriteLine(resultOfMessage);
                }
            }
        }

        static long SumDigits(string number)
        {
            long sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if(number[i] >= '0' && number[i] <= '9')
                {
                    int digit = number[i] - 48;
                    sum += digit;
                }
            }
            return sum;
        }

        static string GetAResultOfCall(long sum)
        {
            string result = String.Empty;
            if (sum % 2 == 0)
            {
                long minutes = sum / 60;
                long seconds = sum % 60;
                result = $"call ended. duration: {minutes:d2}:{seconds:d2}";
            }
            else
            {
                result = "no answer";
            }
            return result;
        }

        static long SubstractDigits(string number)
        {
            long difference = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] >= '0' && number[i] <= '9')
                {
                    long digit = number[i] - 48;
                    difference -= digit;
                }
            }
            return difference;
        }

        static string GetAResultOfMessage(long sum)
        {
            string result = String.Empty;
            if (sum % 2 == 0)
            {
                result = "meet me there";
            }
            else
            {
                result = "busy";
            }
            return result;
        }
    }
}
