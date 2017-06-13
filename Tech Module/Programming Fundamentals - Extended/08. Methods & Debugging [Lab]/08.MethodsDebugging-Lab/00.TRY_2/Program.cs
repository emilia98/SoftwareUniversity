using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _00.TRY_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = GetNumberOnPower(number,power);
            Console.WriteLine(result); 
        }
        //WITH RECURSION
        static double GetNumberOnPower(double number, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            else
            {
                return number * GetNumberOnPower(number, power - 1);
            }

        }
    }
}
