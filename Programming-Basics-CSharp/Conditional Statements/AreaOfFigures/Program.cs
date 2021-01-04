using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main()
        {
            string fig = Console.ReadLine();

            if (fig == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double S = a * a;
                Console.WriteLine($"{S:f3}");
            }
            else if (fig == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double S = a * b;
                Console.WriteLine("{0:f3}", S);
            }
            else if (fig == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double S = r * r * Math.PI;
                Console.WriteLine(Math.Round(S, 3));
            }
            else if (fig == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                double S = (a * ha) / 2;
                Console.WriteLine($"{S:f3}");
            }
        }
    }
}
