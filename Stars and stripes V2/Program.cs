using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars_and_stripes_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sets the flag width, flag height and the 2 dimensional array
            ushort flagWidth = 38;
            ushort flagHeight = 26;
            char[,] flag = new char[flagHeight, flagWidth];

            // Calculates the width of the canton by multiplying the given flag width with 60.5% (0.605)
            ushort cantonWidth = (ushort)Math.Round(flagWidth * 0.605);

            // Calculates the height of the canton by multiplying the given height with 42.3% (0.423)
            ushort cantonHeight = (ushort)Math.Round(flagHeight * 0.423);

            bool colorRed = false;

            // Height
            for (int y = 0; y < flag.GetLength(0); y++)
            {
                // Changes color of the stripe 
                if (y % 2 == 0)
                    colorRed = !colorRed;

                // Width
                for (int x = 0; x < flag.GetLength(1); x++)
                {
                    // When the x and y is within the canton then make the
                    // background color blue, and foreground color white.
                    if (x <= cantonWidth && y <= cantonHeight) 
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(' ');
                    }
                    // When the x and y isn't within the canton, then make the
                    // background color either red or white. The color will be determined
                    else
                    {
                        if(colorRed)
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                        else
                            Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
