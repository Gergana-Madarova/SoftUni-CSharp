using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine()); 
            double pagesPourHour = double.Parse(Console.ReadLine());
            //Броя на дните, за които трябва да прочете книгата
            int days = int.Parse(Console.ReadLine());

            double result = (pages / pagesPourHour) / days;

            //броят часове, които трябва да отделя за четене всеки ден
            Console.WriteLine(result);
        }
    }
}
