using System;
using System.Collections.Generic;
using System.Linq;

namespace P07AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Where(s => !string.IsNullOrWhiteSpace(s))  //без този ред -> 75/100 точки (без един тест в judge)
                .Reverse()
                .ToList();

            for (int i = 0; i < inputList.Count; i++)
            {
                List<string> outputList = inputList[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                Console.Write(string.Join(' ', outputList));
                if (i != inputList.Count - 1)
                {
                    Console.Write(' ');
                }
            }
        }
    }
}
