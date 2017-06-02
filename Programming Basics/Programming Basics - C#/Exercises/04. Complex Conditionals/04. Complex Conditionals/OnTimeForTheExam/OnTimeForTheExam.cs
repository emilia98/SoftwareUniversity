using System;

namespace OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main()
        {
            int hour_exam = int.Parse(Console.ReadLine());
            int min_exam = int.Parse(Console.ReadLine());
            int hour_arrival = int.Parse(Console.ReadLine());
            int min_arrival = int.Parse(Console.ReadLine());

            int time_exam = hour_exam * 60 + min_exam;
            int time_arrival = hour_arrival * 60 + min_arrival;

            int timeInterval = time_exam - time_arrival;

            if (timeInterval >= 0 && timeInterval <= 30)
            {
                Console.WriteLine("On time");
                if (timeInterval == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start", timeInterval);
                }
            }

            else if (timeInterval > 30)
            {
                Console.WriteLine("Early");

                if (timeInterval < 60)
                {
                    Console.WriteLine("{0} minutes before the start", timeInterval);
                }
                else
                {
                    Console.WriteLine("{0}:{1:00} hours before the start", timeInterval / 60, timeInterval - (timeInterval / 60) * 60);
                }
            }

            else
            {
                Console.WriteLine("Late");
                timeInterval = -timeInterval;

                if (timeInterval < 60)
                {
                    Console.WriteLine("{0} minutes after the start", timeInterval);
                }
                else
                {
                    Console.WriteLine("{0}:{1:00} hours after the start", timeInterval / 60, timeInterval - (timeInterval/60)*60);
                }
            }
        }
    }
}
