using System;
using System.Linq;

namespace _08.CondenseArrayToNumber_2
{
    class CondenseArrayToNumber_2
    {
        static void Main()
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();    
            int result = array[0];
            int cnt = 0;

            int size = array.Length;

            while (size != 1)
            {
                var condensedArray = new int[size - 1];
                for (int index = 0; index < size - 1; index++)
                {
                    condensedArray[cnt] = array[index] + array[index + 1];
                    cnt++;
                }
                Array.Clear(array, 0, size);
                array = condensedArray;
                cnt = 0;
                size = array.Count();

                if (size == 1)
                {
                    result = array[0];
                }
            }
            Console.WriteLine(result);
        }
    }
}
