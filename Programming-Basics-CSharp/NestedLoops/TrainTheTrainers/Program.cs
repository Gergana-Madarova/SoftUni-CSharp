using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());

            double sumGrades = 0.0;
            int counterPr = 0;
            double averageGr = 0.0;
            double totalAverageGr = 0.0;

            string name = Console.ReadLine();
            while (name != "Finish")
            {
                counterPr++;

                for (int i = 1; i <= numPeople; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumGrades += grade;
                }
                averageGr = sumGrades / numPeople;
                totalAverageGr += averageGr;

                Console.WriteLine($"{name} - {averageGr:f2}.");
                sumGrades = averageGr = 0.0;

                name = Console.ReadLine();
            }

            //среден успех от всички презентации => брой презентации
            Console.WriteLine($"Student's final assessment is {(totalAverageGr/counterPr):f2}.");
        }
    }
}
