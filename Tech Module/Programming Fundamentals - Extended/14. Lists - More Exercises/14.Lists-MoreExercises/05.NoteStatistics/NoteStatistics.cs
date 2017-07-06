using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.NoteStatistics
{
    class NoteStatistics
    {
        static void Main()
        {
            List<double> frequencies = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            List<string> notes = new List<string>();
            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();

            double sumNaturals = 0.0, sumSharps = 0.0;
            for (int i = 0; i < frequencies.Count; i++)
            {
                int currentNote = (int)(frequencies[i] * 100);
                string note = String.Empty;
                bool isNatural = false;
                bool isSharp = false;                

                switch(currentNote)
                {
                    case 26163:
                        {
                            isNatural = true;
                            note = "C";                           
                            break;
                        }
                    case 27718:
                        {
                            isSharp = true;
                            note = "C#";
                            break;
                        }
                    case 29366:
                        {
                            isNatural = true;
                            note = "D";
                            break;
                        }
                    case 31113:
                        {
                            isSharp = true;
                            note = "D#";
                            break;
                        }
                    case 32963:
                        {
                            isNatural = true;
                            note = "E";
                            break;
                        }
                    case 34923:
                        {
                            isNatural = true;
                            note = "F";
                            break;
                        }
                    case 36999:
                        {
                            isSharp = true;
                            note = "F#";
                            break;
                        }
                    case 39200:
                        {
                            isNatural = true;
                            note = "G";
                            break;
                        }
                    case 41530:
                        {
                            isSharp = true;
                            note = "G#";
                            break;
                        }
                    case 44000:
                        {
                            isNatural = true;
                            note = "A";
                            break;
                        }
                    case 46616:
                        {
                            isSharp = true;
                            note = "A#";
                            break;
                        }
                    case 49388:
                        {
                            isNatural = true;
                            note = "B";
                            break;
                        }
                }

                notes.Add(note);
                if (isNatural)
                {
                    naturals.Add(note);
                    sumNaturals += currentNote / 100.0;
                }
                else if(isSharp)
                {
                    sharps.Add(note);
                    sumSharps += currentNote / 100.0;
                }
            }
         
            Console.WriteLine("Notes: {0}", String.Join(" ", notes));
            Console.WriteLine("Naturals: {0}", String.Join(", ", naturals));
            Console.WriteLine("Sharps: {0}", String.Join(", ", sharps));
            Console.WriteLine("Naturals sum: {0}", sumNaturals);
            Console.WriteLine("Sharps sum: {0}", sumSharps);

        }
    }
}
