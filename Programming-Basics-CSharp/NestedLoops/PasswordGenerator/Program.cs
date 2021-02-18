using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char k = 'a'; k < (char)l + 97; k++)
                    {
                        for (char m = 'a'; m < (char)l + 97; m++)
                        {
                            int p = 0;
                            if (i >= j)
                            {
                                p = i + 1;
                            }
                            else if (j > i)
                            {
                                p = j + 1;
                            }

                            while (p <= n)
                            {
                                string pass = i.ToString() + j + k + m + p;
                                Console.Write(pass + " ");
                                p++;
                            }
                        }
                    }
                }
            }
        }

        //Console.Write((char)(l + 97));
    }
}
