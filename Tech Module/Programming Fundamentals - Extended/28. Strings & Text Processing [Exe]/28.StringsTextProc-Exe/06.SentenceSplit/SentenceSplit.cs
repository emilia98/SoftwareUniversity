using System;

namespace _06.SentenceSplit
{
    class SentenceSplit
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string delimiterAsString = Console.ReadLine();

            char[] delimiter = delimiterAsString.ToCharArray();

            string[] splitInput = input.Split(new string[] { delimiterAsString }, 
                                               StringSplitOptions.None);
           
            Console.WriteLine("[{0}]", String.Join(", ", splitInput));

            /*string[] splitInput1 = input.Split(new string[] { delimiterAsString },
                                               StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("[{0}]", String.Join(", ", splitInput1));
            //Console.WriteLine(String.Join("", splitInput));*/
        }
    }
}

/*INPUT SPECIFICITY
INPUT:
Bau, Chika, Bow Wow, (interval)
, (comma and interval)

OUTPUT:
[Bau, Chika, Bow Wow, ] // StringSplitOptions.None
[Bau, Chika, Bow Wow]  // StringSplitOptions.RemoveEmptyEntries

    */