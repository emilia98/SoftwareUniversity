﻿using System;

namespace _1.Training_Lab
{
    class TrainingLab
    {
        static void Main()
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            int workplaces;

            double lenghtInCm = h * 100;
            double widthInCm = w * 100;

            int workplacesRow = (int)(lenghtInCm / 120);
            //place, which remaines = (widthInCm - 100(for corridor))/70;
            int workplacesColumn = (int)((widthInCm - 100) / 70);

            workplaces = (workplacesRow * workplacesColumn) - 1 - 2;

            Console.WriteLine(workplaces);
        }
    }
}
