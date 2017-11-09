using System;
using System.Linq;

namespace _09.ExtractMiddleElements_2
{
    class ExtractMiddleElements_2
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] middleElements = ReturnResult(array);

            Console.WriteLine("{ " + String.Join(", ", middleElements) + " }");
        }

        static int[] ReturnResult(int[] array)
        {
            var size = array.Length;

            if (size == 1)
            {
                int[] middleElements = new int[1];
                middleElements[0] = array[0];
                return middleElements;
            }
            else
            {
                int counter = size % 2 == 0 ? 2 : 3;
                int startIndex = (int)(size / 2) - 1;
                int[] middleElements = new int[counter];

                for (int cnt = 0; cnt < counter; cnt++)
                {
                    middleElements[cnt] = array[startIndex + cnt];
                }
                return middleElements;
            }
        }
    }
}
