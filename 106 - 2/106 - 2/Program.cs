using System;
using System.Linq;

namespace _106._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int elements = int.Parse(Console.ReadLine());
            int[] sequence = new int[elements];

            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("search sum");
            int X = int.Parse(Console.ReadLine());


            int start = 0;
            int end = elements - 1;
            bool flag = false;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[start] + sequence[end] > X)
                {
                    end--;
                }
                else if (sequence[start] + sequence[end] < X)
                {
                    start++;
                }
                else if (start != end)
                {
                    flag = true;
                }
            }

            if (flag == true)
            {
                Console.WriteLine("found searched sum");
            }
            else
            {
                Console.WriteLine($"searched sum is not found");
            }
        }
    }
}