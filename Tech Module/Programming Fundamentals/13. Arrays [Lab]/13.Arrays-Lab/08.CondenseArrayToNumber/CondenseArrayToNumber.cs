using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int arraySize = array.Length;
            int result = array[0];

            while (arraySize > 1)
            {                
                for(int index = 0; index < arraySize - 1; index++)
                {
                    array[index] = array[index] + array[index + 1];
                }
                int[] savedArray = new int[arraySize - 1];
                Array.Copy(array, savedArray, arraySize - 1);

                if(savedArray.Length == 1)
                {
                    result = savedArray[0];
                }
                arraySize--;
            }
            Console.WriteLine(result);
        }        
    }
}
