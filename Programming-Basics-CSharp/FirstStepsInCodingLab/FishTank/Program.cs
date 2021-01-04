using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //аквариум с формата на паралелепипед
            //размерите са подадени в сантиметри и процент
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            //Един литър вода се равнява на един кубичен дециметър/ 1л=1 дм3/
            //V=a.b.c
            //обема на паралепипед/аквариум от см3 в дм3
            double V = (length * width * h) * 0.001;
            //литри вода, които реално ще трябват
            double Vl = V * (1 - (percentage / 100));

            //колко литра вода ще събира аквариума, акo определен % от вместимостта му е заета
            Console.WriteLine(Vl);
        }
    }
}
