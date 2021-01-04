using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int countOfProjects = int.Parse(Console.ReadLine());
            int hours = countOfProjects * 3;

            Console.WriteLine($"The architect {name} will need {hours} hours to complete {countOfProjects} project/s.");
       }
    }
}
