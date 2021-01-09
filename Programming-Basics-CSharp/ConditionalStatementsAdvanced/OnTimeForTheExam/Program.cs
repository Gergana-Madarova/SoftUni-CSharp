using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minArrival = int.Parse(Console.ReadLine());

            int allMinExam = (hourExam * 60) + minExam;
            int allMinArrival = (hourArrival * 60) + minArrival;
            string output = string.Empty;

            if ((allMinArrival <= allMinExam) && (allMinExam - allMinArrival <= 30))
            {
                Console.WriteLine("On time");
                if (allMinExam - allMinArrival !=0)
                {
                    output = $"{allMinExam - allMinArrival} minutes before the start";
                } 
            }
            else if ((allMinArrival <= allMinExam) && (allMinExam - allMinArrival > 30))
            {
                Console.WriteLine("Early");
                if (allMinExam - allMinArrival <= 59 )
                {
                    output = $"{allMinExam - allMinArrival} minutes before the start";
                }
                else if (allMinExam - allMinArrival > 59)
                {
                    output = $"{(allMinExam - allMinArrival) / 60:0}:{(allMinExam - allMinArrival) % 60:00} hours before the start";
                }
            }
            else if (allMinArrival > allMinExam)
            {
                Console.WriteLine("Late");
                if (allMinArrival - allMinExam <= 59)
                {
                    output = $"{allMinArrival - allMinExam} minutes after the start";
                }
                else if (allMinArrival - allMinExam > 59)
                {
                    int hh = (allMinArrival - allMinExam) / 60;
                    int mm = (allMinArrival - allMinExam) % 60;
                    output = $"{hh:0}:{mm:00} hours after the start";
                }
            }

            Console.WriteLine(output);
        }
    }
}
