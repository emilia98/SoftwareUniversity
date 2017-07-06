using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.NoteStatistics_2
{
    class NoteStatistics_2
    {
        static List<double> frequencies = new List<double>();

        static void Main()
        {
            frequencies = GetANewList(frequencies);

            string result = GetAResult(frequencies);
            Console.WriteLine(result);
        }

        static List<double> GetANewList(List<double> list)
        {
            list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            return list;
        }

        static string GetAResult(List<double> frequencies)
        {
            string result = String.Empty;
            
            List<string> notes = new List<string>();
            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();

            double sumNaturals = 0, sumSharps = 0;
            for (int i = 0; i < frequencies.Count; i++)
            {
                double currentNote = frequencies[i];

                if (currentNote == 261.63)
                {
                    notes.Add("C");
                    naturals.Add("C");
                    sumNaturals += currentNote;
                }
                else if (currentNote == 277.18)
                {
                    notes.Add("C#");
                    sharps.Add("C#");
                    sumSharps += currentNote;
                }
                else if (currentNote == 293.66)
                {
                    notes.Add("D");
                    naturals.Add("D");
                    sumNaturals += currentNote;
                }
                else if (currentNote == 311.13)
                {
                    notes.Add("D#");
                    sharps.Add("D#");
                    sumSharps += currentNote;
                }
                else if (currentNote == 329.63)
                {
                    notes.Add("E");
                    naturals.Add("E");
                    sumNaturals += currentNote;
                }
                else if (currentNote == 349.23)
                {
                    notes.Add("F");
                    naturals.Add("F");
                    sumNaturals += currentNote;
                }
                else if (currentNote == 369.99)
                {
                    notes.Add("F#");
                    sharps.Add("F#");
                    sumSharps += currentNote;
                }
                else if (currentNote == 392.00)
                {
                    notes.Add("G");
                    naturals.Add("G");
                    sumNaturals += currentNote;
                }
                else if (currentNote == 415.30)
                {
                    notes.Add("G#");
                    sharps.Add("G#");
                    sumSharps += currentNote;
                }
                else if (currentNote == 440.00)
                {
                    notes.Add("A");
                    naturals.Add("A");
                    sumNaturals += currentNote;
                }
                else if (currentNote == 466.16)
                {
                    notes.Add("A#");
                    sharps.Add("A#");
                    sumSharps += currentNote;
                }
                else if (currentNote == 493.88)
                {
                    notes.Add("B");
                    naturals.Add("B");
                    sumNaturals += currentNote;
                }                           
            }

            result += $"Notes: {String.Join(" ", notes)} \n";
            result += $"Naturals: {String.Join(", ", naturals)} \n";
            result += $"Sharps: {String.Join(", ", sharps)} \n";
            result += $"Naturals sum: {sumNaturals} \n";
            result += $"Sharps sum: {sumSharps} \n";

            return result;
        }
    }
}
