using System;

namespace _05.ForeignLanguages
{
    class ForeignLanguages
    {
        static void Main()
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "USA":
                case "England":
                    {
                        Console.WriteLine("English");
                        break;
                    }
                case "Argentina":
                case "Mexico":
                case "Spain":
                    {
                        Console.WriteLine("Spanish");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("unknown");
                        break;
                    }
            }
        }
    }
}
