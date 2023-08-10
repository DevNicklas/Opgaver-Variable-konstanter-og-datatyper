using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarsAndStripes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Red and white stripes
            for (int y = 0; y < 13; y++)
            {
                // Chooses between red stripes or white stripes
                if (y % 2 == 0)
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                else
                    Console.BackgroundColor = ConsoleColor.White;

                // Prints 2 rows of the chosen stripe color with ' ' as char
                for (int i = 0; i < 2; i++)
                {
                    for (int x = 0; x < 38; x++)
                        Console.Write(' ');
                    Console.WriteLine();
                }
            }

            // The blue area
            Console.SetCursorPosition(0,0);
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            for (int y = 0; y < 11; y++)
            {
                for (int x = 0; x < 23; x++)
                    Console.Write(' ');
                Console.WriteLine();
            }

            // Stars
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            for (int y = 1; y < 10; y++)
            {
                // First row of stars
                Console.SetCursorPosition(1, y);
                for (int x = 0; x < 22; x++)
                {
                    if (x % 4 == 0)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }

                // Second row of stars
                if (y != 9)
                {
                    y++;
                    Console.SetCursorPosition(3, y);
                    for (int x = 0; x < 19; x++)
                    {
                        if (x % 4 == 0)
                            Console.Write('*');
                        else
                            Console.Write(' ');
                    }
                }
            }

            // Waits for an input from user
            Console.ReadLine();
        }
    }
}
