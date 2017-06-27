using System;

namespace _08.GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main()
        {
            string type = Console.ReadLine();

            if(type == "int")
            {
                int firstValue = int.Parse(Console.ReadLine());
                int secondValue = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstValue, secondValue));
            }
            else if(type == "char")
            {
                char firstValue = char.Parse(Console.ReadLine());
                char secondValue = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstValue, secondValue));                 
            }
            else if(type == "string")
            {
                string firstValue = Console.ReadLine();
                string secondValue = Console.ReadLine();
                Console.WriteLine(GetMax(firstValue, secondValue)); 
            }
        }

        static int GetMax(int firstValue, int secondValue)
        {
            if(firstValue >= secondValue)
            {
                return firstValue;
            }
            else{
                return secondValue;
            }
        }

        static char GetMax(char firstValue, char secondValue)
        {
            if (firstValue >= secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }

        static string GetMax(string firstValue, string secondValue)
        {
            if (firstValue.CompareTo(secondValue) > 0)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
    }
}
