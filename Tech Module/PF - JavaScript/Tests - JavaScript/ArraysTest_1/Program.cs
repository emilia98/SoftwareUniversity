using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysTest_1
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int[] condensedArray = new int[array.Length - 1];
            int result = array[0];
            int cnt = 0;

            int size = array.Length;
            while (size != 1)
            {
                int[] condensedArray = new int[size - 1];
                for (int index = 0; index < size - 1; index++)
                {
                    //Console.WriteLine(array[index]);
                   //Console.WriteLine(array[index + 1]);
                    //Console.WriteLine(condensedArray[cnt]);
                    condensedArray[cnt] = array[index] + array[index + 1];
                    cnt++;
                }

                Array.Clear(array, 0, size);
                condensedArray.CopyTo(array, 0);
                //Array.Copy(condensedArray, array, size - 1);
                //Console.WriteLine(String.Join(" ", array));
                cnt = 0;
                size = array.Count();
               

                Console.WriteLine("Size: " + size);
                if(size == 1)
                {
                    result = array[0];
                }
                Console.WriteLine(String.Join(" ", condensedArray));
            }
           
            
            Console.WriteLine(result);
            
        }   
    }
}
