using System;

namespace _07.GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main()
        {
            string type = Console.ReadLine();

            if(type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int greaterValue = GetGreaterValue(num1, num2);
                Console.WriteLine(greaterValue);
            }
            else if(type == "string")
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                string greaterValue = GetGreaterValue(str1, str2);
                Console.WriteLine(greaterValue);
            }
            else if(type == "char")
            {
                char ch1 = char.Parse(Console.ReadLine());
                char ch2 = char.Parse(Console.ReadLine());
                char greaterValue = GetGreaterValue(ch1, ch2);
                Console.WriteLine(greaterValue);
            }


        }

        static int GetGreaterValue(int num1, int num2)
        {
            int greater;
            if(num1 >= num2)
            {
                greater = num1;
            }
            else
            {
                greater = num2;
            }
            return greater;
        }

        static char GetGreaterValue(char ch1, char ch2)
        {
            char greater;

            if(ch1 >= ch2)
            {
                greater = ch1;
            }
            else
            {
                greater = ch2;
            }
            return greater;
        }

        static string GetGreaterValue(string str1, string str2)
        {
            string greater;

            int lengthStr1 = str1.Length;
            int lengthStr2 = str2.Length;

            if(lengthStr1 >= lengthStr2)
            {
                greater = str1;
                for (int i = 0; i < lengthStr1; i++)
                {
                    if(str1[i] == str2[i])
                    {
                        continue;
                    }
                    else
                    {
                        if(str1[i] > str2[i])
                        {
                            greater = str1;
                            break;
                        }
                        else
                        {
                            greater = str2;
                            break;
                        }
                    }
                }
            }
            else 
            {
                greater = str2;
                for (int i = 0; i < lengthStr2; i++)
                {
                    if (str1[i] == str2[i])
                    {
                        continue;
                    }
                    else
                    {
                        if (str1[i] > str2[i])
                        {
                            greater = str1;
                            break;
                        }
                        else
                        {
                            greater = str2;
                            break;
                        }
                    }
                }
            }
            return greater;
        }
    }
}
