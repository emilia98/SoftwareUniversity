using System;

namespace _06.Notifications
{
    class Notifications
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            HaveAMessage(n);
        }

        static void HaveAMessage(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string operation = Console.ReadLine();

                if (input == "success")
                {
                    string message = Console.ReadLine();
                    string success = ShowSuccess(operation, message);
                    Console.WriteLine(success);
                }
                else if (input == "error")
                {
                    int code = int.Parse(Console.ReadLine());
                    string error = ShowError(operation, code);
                    Console.WriteLine(error);
                }
                else
                {
                    continue;
                }
            }
        }

        static string ShowSuccess(string operation, string message)
        {
            string result = String.Empty;
            result += $"Successfully executed {operation}.\n";
            result += $"==============================\n";
            result += $"Message: {message}.";
            return result;
        }

        static string ShowError(string operation, int code)
        {
            string result = String.Empty;
            result += $"Error: Failed to execute {operation}.\n";
            result += $"==============================\n";
            result += $"Error Code: {code}.\n";

            if (code >= 0)
            {
                result += $"Reason: Invalid Client Data.";
            }
            else
            {
                result += $"Reason: Internal System Failure.";
            }
            return result;
        }
    }
}
