using System;

namespace _4.Trainers_Salary
{
    class TrainersSalary
    {
        static void Main()
        {
            int lecturesCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            string lecturer;
            int roliCount = 0;
            int royalCount = 0;
            int jelevCount = 0;
            int trofonCount = 0;
            int sinoCount = 0;
            int othersCount = 0;

            for (int i = 1; i <= lecturesCount; i++)
            {
                lecturer = Console.ReadLine();

                if (lecturer == "Jelev")
                {
                    jelevCount++;
                }
                else if (lecturer == "RoYaL")
                {
                    royalCount++;
                }
                else if (lecturer == "Roli")
                {
                    roliCount++;
                }
                else if (lecturer == "Trofon")
                {
                    trofonCount++;
                }
                else if (lecturer == "Sino")
                {
                    sinoCount++;
                }
                else
                {
                    othersCount++;
                }

            }

            double moneyPerLection = budget / lecturesCount;
            double jelevSalary = moneyPerLection * jelevCount;
            double roliSalary = moneyPerLection * roliCount;
            double royalSalary = moneyPerLection * royalCount;
            double trofonSalary = moneyPerLection * trofonCount;
            double sinoSalary = moneyPerLection * sinoCount;
            double othersSalary = moneyPerLection * othersCount;

            Console.WriteLine("Jelev salary: {0:f2} lv", jelevSalary);
            Console.WriteLine("RoYaL salary: {0:f2} lv", royalSalary);
            Console.WriteLine("Roli salary: {0:f2} lv", roliSalary);
            Console.WriteLine("Trofon salary: {0:f2} lv", trofonSalary);
            Console.WriteLine("Sino salary: {0:f2} lv", sinoSalary);
            Console.WriteLine("Others salary: {0:f2} lv", othersSalary);
        }
    }
}
