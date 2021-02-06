using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            bool home = false;
            int allSteps = 0;

            while (true)
            {
                string steps = (Console.ReadLine());
                if (steps == "Going home")
                {
                    steps = Console.ReadLine();
                    allSteps += int.Parse(steps);
                    home = true;
                    break;
                }
                else if (steps != "Going home" && home == false)
                {
                    allSteps += int.Parse(steps);
                }

                if (allSteps >= 10000)
                {
                    break;
                }
            }

            if (allSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{allSteps - 10000} steps over the goal!");
            }
            else if (allSteps < 10000)
            {
                Console.WriteLine($"{10000 - allSteps} more steps to reach goal.");
            }
        }
    }
}
