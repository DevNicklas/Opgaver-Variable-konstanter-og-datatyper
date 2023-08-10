using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fødselsdagen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Writes and calculates the amount of days and years since the given date
            GetBirthday();
        }

        /// <summary>
        /// Calculates and writes the exact years and days since the given date
        /// </summary>
        static void GetBirthday()
        {
            // Gets a date from the user
            DateTime birthdayDate = MainQuestion();

            // Calculates the difference between now and the date given
            TimeSpan timeDiff = GetTimeDiff(birthdayDate);
            
            // Calculates amount of years
            int ageYears = (int)Math.Floor(timeDiff.TotalDays / 365.2425);

            // Calculates the time of days
            birthdayDate = birthdayDate.AddYears(ageYears);
            timeDiff = GetTimeDiff(birthdayDate);
            int ageDays = (int)Math.Floor(timeDiff.TotalDays);

            Console.Clear();
            Console.WriteLine($"You are {ageYears} years and " + ageDays + " days old");
            Console.WriteLine("\nPress R for converting a new number, or any other key for closing the program");

            // Waits for an user input, and if the user presses R, then can the user convert a new number
            if (Console.ReadKey(true).Key == ConsoleKey.R)
                GetBirthday();
        }

        /// <summary>
        /// Calculates the difference between now and <paramref name="dateThen"/>
        /// </summary>
        /// <param name="dateThen">specific date</param>
        /// <returns>A date which the user have chosen</returns>
        static TimeSpan GetTimeDiff(DateTime dateThen) => DateTime.Now - dateThen;

        /// <summary>
        /// Draws a question, and retrieves a user input
        /// </summary>
        /// <returns>The user input as an DateTime</returns>
        static DateTime MainQuestion()
        {
            Console.Clear();

            // Asks a question until the user give an datetime formatted like "ddMMyyyy"
            DateTime date = DateTime.Now;
            do
            {
                Console.WriteLine("Please enter a birthday as a date");
                Console.WriteLine("The date format you need to use, is presented like this 'ddMMyyyy'");
                Console.WriteLine("Example: 1. June 2008, must be written as 01062008");
            }
            while (!DateTime.TryParseExact(Console.ReadLine(), "ddMMyyyy", null, System.Globalization.DateTimeStyles.None, out date));

            return date;
        }
    }
}
