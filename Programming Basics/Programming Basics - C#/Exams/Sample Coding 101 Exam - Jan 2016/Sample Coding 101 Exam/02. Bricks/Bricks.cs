using System;

namespace _02.Bricks
{
    class Bricks
    {
        static void Main()
        {
            int bricksCount = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int wheelbarrowCapacity = int.Parse(Console.ReadLine());

            int bricksPerCourse = workersCount * wheelbarrowCapacity;
            double courses;
            courses = Math.Ceiling(bricksCount * 1.0 / bricksPerCourse);
            if(bricksCount == 0)
            {
                courses = 0;
            }
            else if(bricksCount <= bricksPerCourse)
            {
                 courses = 1;
            }
            else
            { 
                 courses = bricksCount / bricksPerCourse;
                 //Checks if the courses that will be made are full or not. 
                 if (bricksCount  % bricksPerCourse != 0)
                 {
                     courses += 1;
                 }
                 //We don't need else, because we have only one special case -> whether the course will be full or not
                 courses = Math.Ceiling(bricksCount*1.0 / bricksPerCourse);
             }
            Console.WriteLine(courses);
        }
    }
}
