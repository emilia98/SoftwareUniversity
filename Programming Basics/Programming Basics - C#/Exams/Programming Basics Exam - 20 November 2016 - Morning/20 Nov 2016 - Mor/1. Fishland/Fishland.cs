using System;

namespace _1.Fishland
{
    class Fishland
    {
        static void Main()
        {
            double skumriqPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double quantityPalamud = double.Parse(Console.ReadLine());
            double quantitySafrid = double.Parse(Console.ReadLine());
            double quantityMidi = double.Parse(Console.ReadLine());

            double sum = 0;
            double midiSum = quantityMidi * 7.5;
            double safridSum = (0.8 * cacaPrice + cacaPrice) * quantitySafrid;
            double palamudSum = (0.6 * skumriqPrice + skumriqPrice) * quantityPalamud;

            sum = midiSum + safridSum + palamudSum;
            Console.WriteLine("{0:0.00}", sum);

        }
    }
}
