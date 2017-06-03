using System;

namespace _06.DNASequences
{
    class DNASequences
    {
        static void Main()
        {
            int matchSum = int.Parse(Console.ReadLine());
            string dna = "";
            string dna1 = "", dna2 = "", dna3 = "";

            for (int i = 1; i <= 4; i++)
            {
                dna1 = "";

                if (i == 1)
                {
                    dna1 += "A";
                }
                else if(i == 2)
                {
                    dna1 += "C";
                }
                else if(i == 3)
                {
                    dna1 += "G";
                }
                else
                {
                    dna1 += "T";
                }

                for (int j = 1; j <= 4; j++)
                {
                    dna2 = "";

                    if (j == 1)
                    {
                        dna2 += "A";
                    }
                    else if (j == 2)
                    {
                        dna2 += "C";
                    }
                    else if (j == 3)
                    {
                        dna2 += "G";
                    }
                    else
                    {
                        dna2 += "T";
                    }

                    for (int k = 1; k <= 4; k++)
                    {
                        dna3 = "";
                        dna = "";
                        if (k == 1)
                        {
                            dna3 += "A";
                        }
                        else if (k == 2)
                        {
                            dna3 += "C";
                        }
                        else if (k == 3)
                        {
                            dna3 += "G";
                        }
                        else
                        {
                            dna3 += "T";
                        }

                        dna += dna1 + dna2 + dna3;

                        if (i + k + j >= matchSum)
                        {
                            Console.Write($"O{dna}O ");
                        }
                        else
                        {
                            Console.Write($"X{dna}X ");
                        }
                    }
                    Console.WriteLine();
                }   
            }
        }
    }
}
