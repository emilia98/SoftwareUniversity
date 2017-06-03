using System;

namespace _08.SMSTyping_2
{
    class SMSTyping_2
    {
        static void Main()
        {
            int symbolsNumber = int.Parse(Console.ReadLine());
            string text = "";

            int number;
            string numberToString;
            int digits;
            char currentCharacter;

            for (int i = 1; i <= symbolsNumber; i++)
             {
                 number = int.Parse(Console.ReadLine());

                 if(number == 0)
                 {
                     text += " ";
                 }
                 else
                 {
                     numberToString = number.ToString();
                     digits = numberToString.Length;

                     if(numberToString[0] == '2')
                     {
                         currentCharacter = (char)(97 + digits - 1);
                     }
                     else if (numberToString[0] == '3')
                     {
                         currentCharacter = (char)(100 + digits - 1);
                     }
                     else if (numberToString[0] == '4')
                     {
                         currentCharacter = (char)(103 + digits - 1);
                     }
                     else if (numberToString[0] == '5')
                     {
                         currentCharacter = (char)(106 + digits - 1);
                     }
                     else if (numberToString[0] == '6')
                     {
                         currentCharacter = (char)(109 + digits - 1);
                     }
                     else if (numberToString[0] == '7')
                     {
                         currentCharacter = (char)(112 + digits - 1);
                     }
                     else if (numberToString[0] == '8')
                     {
                         currentCharacter = (char)(116 + digits - 1);
                     }
                     else
                     {
                         currentCharacter = (char)(119 + digits - 1);
                     }

                     text += currentCharacter;
                 }
             }
             Console.WriteLine(text);
        }
    }
}
