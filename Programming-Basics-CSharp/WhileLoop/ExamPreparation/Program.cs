using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfFailed = int.Parse(Console.ReadLine());
            string problem = string.Empty;
            int score = 0;
            double sumScore = 0.0;
            int p = 0;
            int curNumOfFailed = 1;
            bool failed = false;
            string lastProblem = string.Empty;

            while (true)
            {
                problem = Console.ReadLine();

                if (problem == "Enough")
                {
                    break;
                }

                score = int.Parse(Console.ReadLine());

                if (score <= 4 && numOfFailed > curNumOfFailed)
                {
                    p++;
                    sumScore += score;
                    curNumOfFailed++;
                    continue;
                }
                else if (score <= 4 && numOfFailed <= curNumOfFailed)
                {
                    failed = true;
                    break;
                }
                else
                {
                    p++;
                    sumScore += score;
                    lastProblem = problem;
                }
            }

            if (failed)
            {
                Console.WriteLine($"You need a break, {numOfFailed} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {sumScore / p:f2}\n" +
                                  $"Number of problems: {p}\n" +
                                  $"Last problem: {lastProblem}");
            }
        }
    }
}
