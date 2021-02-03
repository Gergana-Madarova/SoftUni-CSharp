using System;

namespace Graduation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double averageGrade = double.Parse(Console.ReadLine());
            double averageGradeTotal = 0.0;
            int k = 0;
            bool excluded = false;

            for (int i = 1; i <= 12; i++)
            {
                if (averageGrade < 4.00 && excluded == false)
                {
                    excluded = true;
                    continue;
                }
                else if ((averageGrade < 4.00) && excluded == true)
                {
                    k = i-1;
                    break;
                }
                else
                {
                    averageGradeTotal += averageGrade;
                    if (i == 12)
                    {
                        break;
                    }
                    averageGrade = double.Parse(Console.ReadLine());
                }

            }

            if (excluded == false)
            {
               // Console.WriteLine(averageGradeTotal);
                Console.WriteLine($"{name} graduated. Average grade: {averageGradeTotal / 12:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {k} grade");
            }

            //while (averageGrade>=4.00)
            //{


            //}

            //Console.WriteLine("Hello World!");
        }
    }
}
