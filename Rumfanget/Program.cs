using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumfanget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Draws the result of the calculated volume and waits for an input from the user
            GetResult();
        }

        /// <summary>
        /// Draws a question, and retrieves the user input
        /// </summary>
        /// <returns>The user input as an double</returns>
        static double GetInputWithQuestion(string question)
        {
            // Asks the questions until the user gives an double as answer
            double output = 0;
            do
            {
                Console.WriteLine(question);
            }
            while (!double.TryParse(Console.ReadLine(), out output));

            return output;
        }

        /// <summary>
        /// Draws the result of the calculated volume, and waits for an user input
        /// </summary>
        /// <param name="height">height used to calculate volume</param>
        /// <param name="width">width used to calculate volume</param>
        /// <param name="length">length used to calculate volume</param>
        static void GetResult()
        {
            Console.Clear();
            // Gets the different values for each variable from the user
            double height = GetInputWithQuestion("Please enter the height in centimeters.");
            double width = GetInputWithQuestion("Please enter the width in centimeters.");
            double length = GetInputWithQuestion("Please enter the length in centimeters.");

            // Calculated volume
            double volume = height * width * length;

            // Writes the different information out to the Console Window
            Console.Clear();
            Console.WriteLine($"Height: {height} cm");
            Console.WriteLine($"Width: {width} cm");
            Console.WriteLine($"Length: {length} cm");
            Console.WriteLine($"The volume is {volume} cm.");
            Console.WriteLine("\nPress R for converting a new number, or any other key for closing the program");

            // Waits for an user input, and if the user presses R, then can the user convert a new number
            if (Console.ReadKey(true).Key == ConsoleKey.R)
                GetResult();

        }
    }
}
