using System;
using System.Text;
using System.Collections.Generic;
namespace _106._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //106/5
            string[] colors = {  };

            int red = 0;
            int white = colors.Length - 1;
            for (int i = 0; i < white - 1; i++)
            {
                if (colors[i] == "red")
                {
                    string swap = colors[red];
                    colors[red] = colors[i];
                    colors[i] = swap;
                    red++;
                    i--;
                }
                else if (colors[i] == "white")
                {
                    string swap = colors[i];
                    colors[i] = colors[white];
                    colors[white] = swap;
                    i--;
                    white--;
                }
            }

            for (int i = 0; i < colors.Length; i++)
            {
                Console.Write(colors[i] + ", ");
            }

        }
    }
}