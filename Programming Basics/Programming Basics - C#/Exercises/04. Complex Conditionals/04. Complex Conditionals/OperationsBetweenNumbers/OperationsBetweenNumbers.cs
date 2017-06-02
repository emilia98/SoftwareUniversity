using System;

namespace OperationsBetweenNumbers
{
    class OperationsBetweenNumbers
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            double result;
            string evenOdd;

            if (oper == "+" || oper == "-" || oper == "*")
            {
                if (oper == "+")
                {
                    result = n1 + n2;
                }
                else if(oper == "-")
                {
                    result = n1 - n2;
                }
                else
                {
                    result = n1 * n2;
                }

                if(result%2==0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}",n1,oper,n2,result,evenOdd);
            }
            else if(oper == "/" || oper == "%")
            {
                if(n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero",n1);
                }
                else
                {
                    if (oper == "/")
                    {
                        result = n1 * 1.0 / n2 * 1.0;
                        Console.WriteLine("{0} {1} {2} = {3:0.00}", n1, oper, n2, result);
                    }
                    else
                    {
                        result = n1 % n2;
                        Console.WriteLine("{0} {1} {2} = {3:0}", n1, oper, n2, result);
                    }
                    
                }
            }
        }
    }
}
