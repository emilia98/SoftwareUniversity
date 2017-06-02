using System;

namespace VowelsSum
{
    class VowelsSum
    {
        static void Main()
        {
            string str = Console.ReadLine();
            int strSize, sum = 0;

            strSize = str.Length;

            for (int i = 0; i < strSize; i++)
            {
                switch (str[i])
                {
                    case 'a':
                        {
                            sum += 1;
                            break;
                        }
                    case 'e':
                        {
                            sum += 2;
                            break;
                        }
                    case 'i':
                        {
                            sum += 3;
                            break;
                        }
                    case 'o':
                        {
                            sum += 4;
                            break;
                        }
                    case 'u':
                        {
                            sum += 5;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
