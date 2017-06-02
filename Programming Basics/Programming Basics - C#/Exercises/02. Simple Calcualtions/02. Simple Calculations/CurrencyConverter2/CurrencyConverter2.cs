using System;

namespace CurrencyConverter2
{
    class CurrencyConverter2
    {
        static void Main()
        {
            double value = double.Parse(Console.ReadLine());
            string currency1 = Console.ReadLine();
            string currency2 = Console.ReadLine();
            double result = 0;

            double bgn = 1;
            double usd = 1.79549;
            double euro = 1.95583;
            double gbp = 2.53405;

            if (currency1 == currency2)
            {
                Console.WriteLine("{0} {1}", Math.Round(value, 2), currency1);
            }
            else
            {
                switch(currency1)
                {
                    case "BGN":
                        {
                            switch (currency2)
                            {
                                case "USD":
                                    {
                                        result = value/usd;
                                        break;
                                    }
                                case "EUR":
                                    {
                                        result = value / euro;
                                        break;
                                    }
                                case "GBP":
                                    {
                                        result = value / gbp;
                                        break;
                                    }
                            }
                            Console.WriteLine("{0} {1}", Math.Round(result, 2), currency2);
                            break;
                        
                        }
                    case "USD":
                        {
                            switch (currency2)
                            {
                                case "BGN":
                                    {
                                        result = value * usd;
                                        break;
                                    }
                                case "EUR":
                                    {
                                        result = (usd / euro) * value;
                                        break;
                                    }
                                case "GBP":
                                    {
                                        result = (usd / gbp) * value;
                                        break;
                                    }
                            }
                            Console.WriteLine("{0} {1}", Math.Round(result, 2), currency2);
                            break;
                        }
                    case "EUR":
                        {
                            switch (currency2)
                            {
                                case "BGN":
                                    {
                                        result = value * euro;
                                        break;
                                    }
                                case "USD":
                                    {
                                        result = (euro / usd) * value;
                                        break;
                                    }
                                case "GBP":
                                    {
                                        result = (euro / gbp) * value;
                                        break;
                                    }
                            }
                            Console.WriteLine("{0} {1}", Math.Round(result, 2), currency2);
                            break;
                        }
                    case "GBP":
                        {
                            switch (currency2)
                            {
                                case "BGN":
                                    {
                                        result = value * gbp;
                                        break;
                                    }
                                case "EUR":
                                    {
                                        result = (gbp / euro) * value;
                                        break;
                                    }
                                case "USD":
                                    {
                                        result = (gbp / usd) * value;
                                        break;
                                    }
                            }
                            Console.WriteLine("{0} {1}", Math.Round(result, 2), currency2);
                            break;
                        }
                }
            }
            
        }
    }
}
