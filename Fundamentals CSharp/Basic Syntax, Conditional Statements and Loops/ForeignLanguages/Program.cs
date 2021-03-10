using System;

namespace ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string language = "unknown";

            switch (name)
            {
                case "England":
                case "USA":
                    {
                        language = "English";
                        break;
                    }
                case "Spain":
                case "Argentina":
                case "Mexico":
                    {
                        language = "Spanish";
                        break;
                    }
            }
            Console.WriteLine(language);
        }
    }
}
