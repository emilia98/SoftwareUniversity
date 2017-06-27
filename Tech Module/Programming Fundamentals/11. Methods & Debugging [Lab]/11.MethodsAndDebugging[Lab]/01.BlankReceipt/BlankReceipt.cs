using System;

namespace _01.BlankReceipt
{
    class BlankReceipt
    {
        static void Main()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(" ------------------------------");
        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Console.WriteLine("\u00A9 SoftUni");
        }
    }
}
