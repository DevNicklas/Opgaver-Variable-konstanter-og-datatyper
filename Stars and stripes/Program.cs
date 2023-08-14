using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars_and_stripes
{
    internal class Program
    {
        const byte width = 38;
        const byte height = 26;

        static void Main(string[] args)
        {
            // Draws the flag and shows it on the Console Window
            DrawFlag();
            Console.ReadLine();
        }

        /// <summary>
        /// Draws stripes with a chosen background color
        /// </summary>
        /// <param name="color">background color</param>
        static void DrawStripe(ConsoleColor color)
        {
            Console.BackgroundColor = color;
            for(int y = 0; y < 2; y++)
                Console.WriteLine(new string(' ', width));
        }

        /// <summary>
        /// Draws the blue area of the flag
        /// </summary>
        static void DrawCantonStripe()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(new string(' ', width-15));
        }

        /// <summary>
        /// Draws the white stars on the blue area
        /// </summary>
        /// <param name="startPosX">the x position to start at</param>
        /// <param name="startPosY">the y position to start at</param>
        /// <param name="subtractHeight">height to subtract from the height of the flag, which prevents overlaps with the blue color</param>
        static void DrawStars(int startPosX, int startPosY, int subtractHeight)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            
            // Prints from top to bottom
            for(int y = 0; y < height-subtractHeight; y++)
            {
                // Moves the cursor position down from the startPosY
                Console.SetCursorPosition(startPosX, startPosY + y);

                // Prints a star every 2nd row
                if (y % 2 == 0)
                    Console.WriteLine('*');
                else
                    Console.WriteLine(' ');
            }
        }

        /// <summary>
        /// Draws the flag
        /// </summary>
        static void DrawFlag()
        {
            // Red and white stripes
            for (int y = 0; y < height / 2; y++)
            {
                if (y % 2 == 0)
                    DrawStripe(ConsoleColor.DarkRed);
                else
                    DrawStripe(ConsoleColor.White);
            }

            // Blue area
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < height - 15; y++)
                DrawCantonStripe();

            // Stars
            for(int x = 0; x < 6; x++)
                DrawStars(x*4+1, 1, 17);
            for (int x = 0; x < 5; x++)
                DrawStars(x * 4 + 3, 2, 18);
        }
    }
}
