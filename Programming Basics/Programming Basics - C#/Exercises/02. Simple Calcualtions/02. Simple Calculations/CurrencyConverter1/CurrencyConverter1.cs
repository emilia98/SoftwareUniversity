using System;

namespace CurrencyConverter1
{
    class CurrencyConverter1
    {
        static void Main()
        {
            double value = double.Parse(Console.ReadLine());
            string currency1 = Console.ReadLine();
            string currency2 = Console.ReadLine();
            double result;

            if (currency1 == "BGN")
            {
                if (currency2 == "USD")
                {
                    result = value/1.79549;
                    Console.WriteLine("{0} USD", Math.Round(result, 2));
                }
                if (currency2 == "EUR")
                {
                    result = value/1.95583;
                    Console.WriteLine("{0} EUR", Math.Round(result, 2));
                }
                if (currency2 == "GBP")
                {
                    result = value/2.53405;
                    Console.WriteLine("{0} GBP", Math.Round(result, 2));
                }
                if (currency2 == "BGN")
                {
                    result = value;
                    Console.WriteLine("{0} BGN", Math.Round(result, 2));
                }
            }

            if (currency1 == "USD")
            {
                if (currency2 == "BGN")
                {
                    result = value*1.79549;
                    Console.WriteLine("{0} USD", Math.Round(result, 2));
                }
                if (currency2 == "EUR")
                {
                    result = (1.79549/1.95583) * value;
                    Console.WriteLine("{0} EUR", Math.Round(result, 2));
                }
                if (currency2 == "GBP")
                {
                    result = (1.79549/2.53405) * value;
                    Console.WriteLine("{0} GBP", Math.Round(result, 2));
                }
                if (currency2 == "USD")
                {
                    result = value;
                    Console.WriteLine("{0} USD", Math.Round(result, 2));
                }
            }

            if (currency1 == "EUR")
            {
                if (currency2 == "BGN")
                {
                    result = value * 1.95583;
                    Console.WriteLine("{0} USD", Math.Round(result, 2));
                }
                if (currency2 == "USD")
                {
                    result = (1.95583/1.79549) * value;
                    Console.WriteLine("{0} EUR", Math.Round(result, 2));
                }
                if (currency2 == "GBP")
                {
                    result = (1.95583/2.53405) * value;
                    Console.WriteLine("{0} GBP", Math.Round(result, 2));
                }
                if (currency2 == "EUR")
                {
                    result = value;
                    Console.WriteLine("{0} EUR", Math.Round(result, 2));
                }
            }

            if (currency1 == "GBP")
            {
                if (currency2 == "BGN")
                {
                    result = value * 2.53405;
                    Console.WriteLine("{0} USD", Math.Round(result, 2));
                }
                if (currency2 == "USD")
                {
                    result = (2.53405/ 1.79549) * value;
                    Console.WriteLine("{0} EUR", Math.Round(result, 2));
                }
                if (currency2 == "EUR")
                {
                    result = (2.53405/1.95583) * value;
                    Console.WriteLine("{0} GBP", Math.Round(result, 2));
                }
                if (currency2 == "GBP")
                {
                    result = value;
                    Console.WriteLine("{0} GBP", Math.Round(result, 2));
                }
            }
        }
    }
}
