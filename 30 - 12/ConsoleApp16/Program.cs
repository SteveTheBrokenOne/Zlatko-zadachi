using System;
using System.Text;
using System.Collections.Generic;

namespace _30._12
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindrom = Console.ReadLine();
            string reverse = string.Empty;
            string reversePalindrom = Recursion(palindrom, palindrom.Length - 1, reverse);

            if (reversePalindrom == palindrom)
            {
                Console.WriteLine("Its palindrom");
            }
            else
            {
                Console.WriteLine("its not palindrom");
            }

        }
        static string Recursion(string palindrom, int end, string reverseP)
        {
            if (palindrom.Length == 0)
            {
                return palindrom;
            }
            if (end < 0)
            {
                return reverseP;
            }
            reverseP += palindrom[end];
            return Recursion(palindrom, --end, reverseP);
        }
    }
}