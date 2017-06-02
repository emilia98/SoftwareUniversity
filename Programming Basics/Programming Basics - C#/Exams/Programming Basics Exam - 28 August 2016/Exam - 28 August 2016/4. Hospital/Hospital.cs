using System;

namespace _4.Hospital
{
    class Hospital
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int patients;
            int treatedPatients = 0, untreatedPatients = 0;
            int sumTreatedPatients = 0, sumUntreatedPatients = 0;
            int doctors = 7;


            for (int i = 1; i <= days; i++)
            {
                patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    if (sumUntreatedPatients > sumTreatedPatients)
                    {
                        doctors++;
                    }
                }

                if (patients <= doctors)
                {
                    treatedPatients = patients;
                    untreatedPatients = 0;
                }
                else
                {
                    treatedPatients = doctors;
                    untreatedPatients = patients - treatedPatients;
                }

                sumTreatedPatients += treatedPatients;
                sumUntreatedPatients += untreatedPatients;
            }
            Console.WriteLine("Treated patients: {0}.", sumTreatedPatients);
            Console.WriteLine("Untreated patients: {0}.", sumUntreatedPatients);
        }
    }
}
