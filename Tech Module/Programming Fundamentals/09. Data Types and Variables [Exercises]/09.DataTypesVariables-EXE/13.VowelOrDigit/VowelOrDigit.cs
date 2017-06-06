using System;

namespace _13.VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main()
        {
            char symbol = char.Parse(Console.ReadLine());

            if(symbol >= '0' && symbol <= '9')
            {
                Console.WriteLine("digit");
            }
            else if(symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'u' || symbol == 'o')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
