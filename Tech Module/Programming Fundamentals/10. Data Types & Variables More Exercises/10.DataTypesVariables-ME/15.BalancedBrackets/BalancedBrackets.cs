using System;

namespace _15.BalancedBrackets
{
    class BalancedBrackets
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool thereIsOpeningBracket = false;
            bool isBalanced = true;
            int bracketCount = 0;

            string[] str = new string[n];

            for (int i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();

                if (str[i] == "(" || str[i] == ")")
                {
                    bracketCount++;
                }
            }

            if (bracketCount % 2 == 1)
            {
                isBalanced = false;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (str[i] == "(")
                    {
                        thereIsOpeningBracket = true;
                        isBalanced = false;
                        continue;
                    }

                    if (str[i] == ")" && thereIsOpeningBracket)
                    {
                        isBalanced = true;
                        thereIsOpeningBracket = false;
                        continue;
                    }

                    if (str[i] == ")" && thereIsOpeningBracket == false)
                    {
                        isBalanced = false;
                        break;
                    }

                    if (str[i] == "(" && thereIsOpeningBracket == true)
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
