using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturberegneren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Draws the result of the converted 
            Result(MainQuestion());
        }

        /// <summary>
        /// Draws an question, and retrieves the user input
        /// </summary>
        /// <returns>The user input as an float</returns>
        static float MainQuestion()
        {
            Console.Clear();

            // Asks the questions until the user give an float as answer
            float inputCelcius = 0;
            do
            {
                Console.WriteLine("Please enter the number you want to convert in celcius.");
            }
            while (!float.TryParse(Console.ReadLine(), out inputCelcius));

            return inputCelcius;
        }

        /// <summary>
        /// Convert from celcius to fahrenheit
        /// </summary>
        /// <param name="celciusNum">number in celcius which will be converted</param>
        /// <returns>The result of converting celcius to fahrenheit as a float</returns>
        static float ConvertToFahreinheit(float celciusNum) => celciusNum*1.8F+32;

        /// <summary>
        /// Convert from celcius to reaumur
        /// </summary>
        /// <param name="celciusNum">number in celcius which will be converted</param>
        /// <returns>The result of converting celcius to reaumur as a float</returns>
        static float ConvertToReaumur(float celciusNum) => celciusNum * 0.8F;

        /// <summary>
        /// Draws the result of the converted celcius, and waits for an user input. Fahrenheit and Reaumur will be shown
        /// </summary>
        /// <param name="celciusNum">number in celcius which will be converted</param>
        static void Result(float celciusNum)
        {
            float fahreinheit = ConvertToFahreinheit(celciusNum);
            float reaumur = ConvertToReaumur(celciusNum);

            Console.Clear();
            Console.WriteLine($"Celcius which is converted: {celciusNum} °C\n");
            Console.WriteLine($"Fahrenheit: {fahreinheit} °F");
            Console.WriteLine($"Reaumur: {reaumur} °R");
            Console.WriteLine("\nPress R for converting a new number, or any other key for closing the program");

            if (Console.ReadKey(true).Key == ConsoleKey.R)
                Result(MainQuestion());
        }
    }
}
