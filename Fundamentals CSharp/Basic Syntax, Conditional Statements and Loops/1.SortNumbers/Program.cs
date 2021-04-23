using System;

namespace _1.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                if (n2 <= n3)
                {
                    int m = n3;
                    n2 = n3;
                    n3 = m;
                }
            }
            else if (n2 > n1 && n2 > n3)
            {
                int max = n2;

                if (n1 < n3)
                {
                    int m = n3;
                    n3 = n1;
                    n1 = max;
                    n2 = m;
                }
                else if (n1 >= n3)
                {
                    n2 = n1;
                    n1 = max;
                }
            }
            else if (n3 > n1 && n3 > n2)
            {
                int max = n3;

                if (n1 > n2)
                {
                    int m = n1;
                    n1 = max;
                    n3 = n2;
                    n2 = m;
                }
                else if (n1 <= n2)
                {
                    n3 = n1;
                    n1 = max;
                }
            }

            Console.WriteLine(n1 + "\n" + n2 + "\n" + n3 + "\n");
        }
    }
}
