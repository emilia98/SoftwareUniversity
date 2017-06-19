using System;

namespace _01.Hello_Name
{
    class HelloName
    {
        static void Main()
        {
            string name = Console.ReadLine();
            SayHello(name);
        }

        static void SayHello(string name)
        {
            Console.WriteLine("Hello, {0}!",name);
        }
    }
}
