using System;

namespace _4.Grades
{
    class Grades
    {
        static void Main()
        {
            uint studentCount = uint.Parse(Console.ReadLine());
            double studentMark;

            double marksSum = 0;
            uint topStudents = 0;
            uint goodStudents = 0;
            uint middleStudents = 0;
            uint failedStudents = 0;

            for (uint student = 1; student <= studentCount; student++)
            {
                studentMark = double.Parse(Console.ReadLine());
                marksSum += studentMark;

                if (studentMark >= 5.00)
                {
                    topStudents++;
                }
                else if (studentMark >= 4.00 && studentMark <= 4.99)
                {
                    goodStudents++;
                }
                else if (studentMark >= 3.00 && studentMark <= 3.99)
                {
                    middleStudents++;
                }
                else
                {
                    failedStudents++;
                }
            }
            double percentageTopStudents = (topStudents * 1.0 / studentCount) * 100;
            double percentageGoodStudents = (goodStudents * 1.0 / studentCount) * 100;
            double percentageMiddleStudents = (middleStudents * 1.0 / studentCount) * 100;
            double percentageFailedStudents = (failedStudents * 1.0 / studentCount) * 100;
            double averageMark = marksSum / studentCount;

            Console.WriteLine("Top students: {0:0.00}%", percentageTopStudents);
            Console.WriteLine("Between 4.00 and 4.99: {0:0.00}%", percentageGoodStudents);
            Console.WriteLine("Between 3.00 and 3.99: {0:0.00}%", percentageMiddleStudents);
            Console.WriteLine("Fail: {0:0.00}%", percentageFailedStudents);
            Console.WriteLine("Average: {0:f2}", averageMark);
        }
    }
}
