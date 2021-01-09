using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char oper =  char.Parse(Console.ReadLine());
            double result = 0.0;

            if (oper == '+' || oper == '-' || oper == '*')
            {
                if (oper == '+')
                {
                    result = n1 + n2;
                }
                else if (oper == '-')
                {
                    result = n1 - n2;
                }
                else if (oper == '*')
                {
                    result = n1 * n2;
                }

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} {oper} {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {oper} {n2} = {result} - odd");
                }
            }
            else if (oper == '/' && n2 !=0)
            {
                Console.WriteLine($"{n1} / {n2} = {(double)n1/n2:f2}");
            }
            else if ((oper =='/' || oper == '%') && n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if (oper == '%' && n2 != 0)
            {
                result = n1 % n2;
                Console.WriteLine($"{n1} % {n2} = {result}");
            }
        }
    }
}
