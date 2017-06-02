using System;

namespace TradeComissions
{
    class TradeComission
    {
        static void Main()
        {
            string place = Console.ReadLine().ToLower();
            double s = double.Parse(Console.ReadLine());
            double comission = 0;
            bool invalidInput = false;

            if (place == "sofia")
            {
                if (s >= 0 && s <= 500)
                {
                    comission = s * 0.05;
                }
                else if (s >= 500 && s <= 1000)
                {
                    comission = s * 0.07;
                }
                else if (s >= 1000 && s <= 10000)
                {
                    comission = s * 0.08;
                }
                else if (s > 10000)
                {
                    comission = s * 0.12;
                }
                else
                {
                    invalidInput = true; ;
                }
            }

            else if (place == "varna")
            {
                if (s >= 0 && s <= 500)
                {
                    comission = s * 0.045;
                }
                else if (s >= 500 && s <= 1000)
                {
                    comission = s * 0.075;
                }
                else if (s >= 1000 && s <= 10000)
                {
                    comission = s * 0.1;
                }
                else if (s > 10000)
                {
                    comission = s * 0.13;
                }
                else
                {
                    invalidInput = true;
                }
            }

            else if (place == "plovdiv")
            {
                if (s >= 0 && s <= 500)
                {
                    comission = s * 0.055;
                }
                else if (s >= 500 && s <= 1000)
                {
                    comission = s * 0.08;
                }
                else if (s >= 1000 && s <= 10000)
                {
                    comission = s * 0.12;
                }
                else if (s > 10000)
                {
                    comission = s * 0.145;
                }
                else
                {
                    invalidInput = true;
                }
            }
            else
            {
                invalidInput = true;
            }

            if(invalidInput)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:0.00}",comission);
            }
        }
    }
}
