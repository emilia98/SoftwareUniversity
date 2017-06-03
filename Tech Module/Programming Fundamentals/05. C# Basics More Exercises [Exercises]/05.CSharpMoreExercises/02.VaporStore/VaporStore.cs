using System;

namespace _02.VaporStore
{
    class VaporStore
    {
        static void Main()
        {
            double startBalance = double.Parse(Console.ReadLine());
            double currentBalance = startBalance;
            string gameTitle = Console.ReadLine();

            double price = 0;
            
            while(gameTitle != "Game Time")
            {

                if (gameTitle == "OutFall 4" || gameTitle == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                }
                else if (gameTitle == "CS: OG")
                {
                    price = 15.99;
                }
                else if (gameTitle == "Zplinter Zell")
                {
                    price = 19.99;
                }
                else if (gameTitle == "Honored 2")
                {
                    price = 59.99;
                }
                else if (gameTitle == "RoverWatch")
                {
                    price = 29.99;
                }
                else
                {
                    price = 0;
                    gameTitle = "Not Found";
                }

                if (price == 0)
                {
                    Console.WriteLine(gameTitle);
                }
                else if (currentBalance < price)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (currentBalance >= price)
                {
                    currentBalance -= price;
                    Console.WriteLine("Bought {0}", gameTitle);
                }

                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                gameTitle = Console.ReadLine();
            }

            double totalSpent = startBalance - currentBalance;
            double moneyLeft =  currentBalance;

            //Console.WriteLine("Total spent: ${0}. Remaining: ${1}", Math.Round(totalSpent,2), Math.Round(moneyLeft, 2));
            Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", totalSpent, moneyLeft);
        }
    }
}
