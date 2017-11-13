using System;
using System.Linq;

namespace _05.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            //input:
            var array1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var array2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
          
            int size1 = array1.Length;
            int size2 = array2.Length;

            if (size1 < size2)
            {
                PrintArray(array1, array2);
            }
            else if (size2 < size1)
            {
                PrintArray(array2, array1);
            }
            else
            {
                bool hasPrinted = false;

                for (int index = 0; index < size1; index++)
                {
                    if (array1[index] < array2[index])
                    {
                        PrintArray(array1, array2);
                        hasPrinted = true;
                        break;
                    }
                    else if (array1[index] > array2[index])
                    {
                        PrintArray(array2, array1);
                        hasPrinted = true;
                        break;
                    }
                }

                if (!hasPrinted)
                {
                    PrintArray(array1, array2);
                }
            }
            //goto input;
        }

        static void PrintArray(char[] arr1, char[] arr2)
        {
            Console.WriteLine(String.Join("", arr1));
            Console.WriteLine(String.Join("", arr2));          
        }
    }
}
