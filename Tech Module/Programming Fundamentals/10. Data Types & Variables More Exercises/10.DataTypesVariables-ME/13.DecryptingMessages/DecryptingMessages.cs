using System;

namespace _13.DecryptingMessages
{
    class DecryptingMessages
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            uint n = uint.Parse(Console.ReadLine());

            string message = String.Empty;
            for (uint i = 1; i <= n; i++)
            {
                char character = char.Parse(Console.ReadLine());
                character = (char)(character + key);
                message += character;
            }
            Console.WriteLine(message);
        }
    }
}
