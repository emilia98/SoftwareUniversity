using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.UserLogins
{
    class UserLogins
    {
        static void Main()
        {
            string str = Console.ReadLine();
            Dictionary<string, string> login = new Dictionary<string, string>();
                       
            GetUsernameAndPassword(login, str);

            str = Console.ReadLine();

            int countUnaccessfulAttempts = 0;
            string result = String.Empty;
            result = TryLogin(login, str, result, ref countUnaccessfulAttempts);
            Console.Write(result);
            Console.WriteLine("unsuccessful login attempts: {0}", countUnaccessfulAttempts);
        }

        static Dictionary<string,string> GetUsernameAndPassword(Dictionary<string, string> login, string str)
        {
            while (true)
            {
                if (str == "login")
                {
                    break;
                }
                string[] splitedString = str.Split(' ').ToArray();
                string username = splitedString[0];
                string password = splitedString[2];

                if (!login.ContainsKey(username))
                {
                    login.Add(username, password);
                }
                else
                {
                    login[username] = password;
                }
                str = Console.ReadLine();
            }
            return login;
        }

        static string TryLogin(Dictionary<string, string> login, string str,
                                                   string result, ref int countUnaccessfulAttempts)
        {
            while (true)
            {
                if (str == "end")
                {
                    break;
                }
                string[] splitedString = str.Split(' ').ToArray();
                string username = splitedString[0];
                string password = splitedString[2];

                if (login.ContainsKey(username) && password == login[username])
                {
                    result += $"{username}: logged in successfully \n";
                }
                else
                {
                    result += $"{username}: login failed \n";
                    countUnaccessfulAttempts++;
                }
                str = Console.ReadLine();
            }
            return result;
        }
    }
}
