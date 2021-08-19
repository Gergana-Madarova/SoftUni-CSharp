using System;
using System.Text.RegularExpressions;

namespace P02FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+[A-Z][0-9A-Za-z]{4,}[A-Z]@#+";
            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                string output =string.Empty;
                Match match = regex.Match(barcode);

                if (match.Success)
                {
                    //взимаме баркода
                    string compare = match.Value;
                    string productGroup = string.Empty;

                    for (int j = 0; j < compare.Length; j++)
                    {
                        if (char.IsDigit(compare[j]))
                        {
                            productGroup += compare[j];
                        }
                    }

                    if (productGroup == "")
                    {
                        output = $"Product group: 00";
                    }
                    else
                    {
                        output = $"Product group: {productGroup}";
                    }
                }
                else
                {
                    output = "Invalid barcode";
                }

                Console.WriteLine(output);
            }
        }
    }
}
