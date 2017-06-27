using System;

namespace _04.DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintEndLine(n);
            PrintMiddleLines(n);
            PrintEndLine(n);
        }

        static void PrintEndLine(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintMiddleLines(int n)
        {
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write('-');
                PrintMiddlePartOfMiddleLine(n);
                Console.WriteLine('-');

            }
        }

        static void PrintMiddlePartOfMiddleLine(int n)
        {
            string middle = String.Empty;
            for (int i = 1; i < n; i++)
            {
                middle += "\\/";
            }
            Console.Write(middle);
        }
    }
}
