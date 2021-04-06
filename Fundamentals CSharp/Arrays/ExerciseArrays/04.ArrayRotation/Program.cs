using System;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            int numberOfRotations = int.Parse(Console.ReadLine());
            string[] result = new string[arr.Length];

            //51    47  32  61  21
            //0     1   2   3   4

            //32 (2+0) 
            //61 (2+1)  
            //21 (2+2)
            //(2+3>=arr.Length)=> arr.Length - j - num = 5 => 2+0
            //(2+4>=arr.Length)=> arr.Length - j - num = 5 => 5-4-2=-1

            for (int j = 0; j < arr.Length; j++)
            {               
                if (numberOfRotations + j < arr.Length)
                {
                    result[j] = arr[numberOfRotations + j];
                }
                else if (numberOfRotations + j >= arr.Length 
                    && Math.Abs(arr.Length - numberOfRotations - j) < arr.Length)
                {
                    result[j] = arr[Math.Abs(arr.Length - numberOfRotations - j)];
                }
                else
                {
                    result[j] = arr[Math.Abs(arr.Length - numberOfRotations - j)-arr.Length];
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
