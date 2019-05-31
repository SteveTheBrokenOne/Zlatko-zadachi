using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61___1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = 0;
            int b = 0;
            s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ('('))
                {
                    a++;
                }
                else if (s[i] == (')'))
                {
                    b++;
                }
                if(b>a)
                {
                    break;
                }
            }   
            if (a == b)
            {
                if (s[0] == ')')
                {
                    Console.WriteLine("Wrong!");
                }
                else Console.WriteLine("right");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
            Console.ReadLine();
            }
        
        }
    }

