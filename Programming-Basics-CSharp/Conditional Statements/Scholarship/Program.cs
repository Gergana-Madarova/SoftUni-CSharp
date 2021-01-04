using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeLv = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double scholarshipForSuccess = 0;
            double socialScholarship = 0;
            string outPut = string.Empty;

            if (averageSuccess >= 5.50)
            {
                scholarshipForSuccess = 25 * averageSuccess;
            }

            if (averageSuccess > 4.50 && incomeLv < minimalSalary)
            {
                socialScholarship = 0.35 * minimalSalary;
            }

            if (scholarshipForSuccess != 0 && socialScholarship == 0)
            {
                outPut = $"You get a scholarship for excellent results {Math.Floor(scholarshipForSuccess)} BGN";
            }
            else if (scholarshipForSuccess == 0 && socialScholarship != 0)
            {
                outPut = $"You get a Social scholarship {Math.Floor(socialScholarship)} BGN";
            }
            else if (scholarshipForSuccess < socialScholarship && scholarshipForSuccess != 0)
            {
                outPut = $"You get a Social scholarship {Math.Floor(socialScholarship)} BGN";
            }
            else if (scholarshipForSuccess >= socialScholarship && scholarshipForSuccess != 0)
            {
                outPut = $"You get a scholarship for excellent results {Math.Floor(scholarshipForSuccess)} BGN";
            }
            else
            {
                outPut = "You cannot get a scholarship!";
            }

            Console.WriteLine(outPut);
        }
    }
}
