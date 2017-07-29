using System;
using System.Collections.Generic;

namespace _06.Messages
{
    class Message
    {
        public string Content { get; set; }
        public string Sender { get; set; }
    }

    class Messages
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var users = new Dictionary<string, List<Message>>();
            var pairSenderReceiver = new List<string>();

            while (input != "exit")
            {
                string[] splitInput = input.Split(' ');

                if (splitInput[0] == "register")
                {
                    string username = splitInput[1];

                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new List<Message>());
                    }
                }
                else
                {
                    string sender = splitInput[0];
                    string recipient = splitInput[2];
                    string content = splitInput[3];

                    if (users.ContainsKey(sender) && users.ContainsKey(recipient))
                    {
                        var message = new Message()
                        {
                            Content = content,
                            Sender = sender,
                        };

                        pairSenderReceiver.Add(sender);
                        pairSenderReceiver.Add(recipient);
                        users[sender].Add(message);
                    }
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            string[] usersToChat = input.Split(' ');
            string user1 = usersToChat[0];
            string user2 = usersToChat[1];

            var user1Messages = new List<string>();
            var user2Messages = new List<string>();

            foreach (var user in users)
            {
                foreach (var message in user.Value)
                {
                    if (message.Sender == user1)
                    {
                        user1Messages.Add(message.Content);
                    }
                    else if (message.Sender == user2)
                    {
                        user2Messages.Add(message.Content);
                    }
                }
            }

            if (!HaveTheyChatted(user1, user2, pairSenderReceiver))
            {
                Console.WriteLine("No messages");
            }
            else
            {
                PrintMessages(user1Messages, user1, user2Messages, user2);
            }
        }

        static bool HaveTheyChatted(string user1, string user2, List<string> pairSenderReceiver)
        {
            for (int index = 0; index < pairSenderReceiver.Count - 1; index += 2)
            {
                if ((pairSenderReceiver[index] == user1 && pairSenderReceiver[index + 1] == user2) ||
                    (pairSenderReceiver[index] == user2 && pairSenderReceiver[index + 1] == user1))
                {
                    return true;
                }
            }
            return false;
        }

        static void PrintMessages(List<string> user1Messages, string user1,
                                  List<string> user2Messages, string user2)
        {
            int countUser1 = user1Messages.Count;
            int countUser2 = user2Messages.Count;

            if (countUser1 >= countUser2)
            {
                PrintRegularChat(user1Messages, user1, user2Messages, user2);

                for (int index = countUser2; index < countUser1; index++)
                {
                    string messageLeft = user1Messages[index];
                    Console.WriteLine("{0}: {1}", user1, messageLeft);
                }
            }
            else
            {
                PrintRegularChat(user1Messages, user1, user2Messages, user2);

                for (int index = countUser1; index < countUser2; index++)
                {
                    string messageLeft = user2Messages[index];
                    Console.WriteLine("{0} :{1}", messageLeft, user2);
                }
            }
        }

        static void PrintRegularChat(List<string> user1Messages, string user1,
                                     List<string> user2Messages, string user2)
        {
            for (int index = 0; index < Math.Min(user1Messages.Count, user2Messages.Count); index++)
            {
                string user1Message = user1Messages[index];
                string user2Message = user2Messages[index];

                Console.WriteLine("{0}: {1}", user1, user1Message);
                Console.WriteLine("{0} :{1}", user2Message, user2);
            }
        }
    }
}

/*
  Warning:
INPUT:
register John
John send Harry harry_you_there?
register Harry
John send Harry harry?
register Donald
Harry send John yeah_sorry_was_out...
Harry send John wassup?
Donald send John Yo_John?
Donald send Jonh You_there?
John send Harry thank_god!!
John send Harry I_need_you!
exit
Harry Donald

OUTPUT:
No messages

 */
