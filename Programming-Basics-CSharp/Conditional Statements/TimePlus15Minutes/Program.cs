using System;
using System.Dynamic;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            string outPut = string.Empty;

            //изчислява колко ще е часът след 15 минути.
            if (minutes < 45)
            {
                minutes += 15;

                if (hour == 23)
                {
                    outPut = $"{hour}:{minutes}";
                }
                else
                {
                    outPut = $"{hour}:{minutes}";
                }
            }
            else if (minutes <= 59 && hour < 23)
            {
                hour++;
                minutes = (minutes + 15) - 60;
                if (minutes < 10)
                {
                    outPut = $"{hour}:0{minutes}";
                }
                else
                {
                    outPut = $"{hour}:{minutes}";
                }
            }
            else if (minutes <= 59 && hour == 23)
            {
                hour = 0;
                minutes = (minutes + 15) - 60;
                if (minutes < 10)
                {
                    outPut = $"{hour}:0{minutes}";
                }
                else
                {
                    outPut = $"{hour}:{minutes}";
                }
            }

            //Часовете винаги са между 0 и 23, а минутите винаги са между 0 и 59.
            //Часовете се изписват с една или две цифри.Минутите се изписват винаги с по две цифри, с водеща нула, когато е необходимо.
            Console.WriteLine(outPut);
        }
    }
}
