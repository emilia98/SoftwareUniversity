using System;

namespace _2.Change_Tiles
{
    class ChangeTiles
    {
        static void Main()
        {
            double collectedMoney = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLength = double.Parse(Console.ReadLine());
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double tilePrice = double.Parse(Console.ReadLine());
            double workmanPrice = double.Parse(Console.ReadLine());

            double floorArea;
            double tileArea;
            int tilesNeeded;
            double moneyNeeded;
            double moneyLeft;

            floorArea = floorWidth * floorLength;
            tileArea = (triangleHeight * triangleSide) / 2;
            tilesNeeded = (int)(Math.Ceiling(floorArea / tileArea)) + 5;

            moneyNeeded = tilesNeeded * tilePrice + workmanPrice;

            if (collectedMoney >= moneyNeeded)
            {
                moneyLeft = collectedMoney - moneyNeeded;
                Console.WriteLine("{0:f2} lv left.", moneyLeft);
            }
            else
            {
                moneyLeft = moneyNeeded - collectedMoney;
                Console.WriteLine("You'll need {0:0.00} lv more.", moneyLeft);
            }
        }
    }
}
