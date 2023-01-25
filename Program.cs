/* 
 Author: Jacquelyn Bowen
 Date: 1/19/2023
 Description: C# Console Application for calculating letter grades.
*/

using System;
using System.Diagnostics.Metrics;

namespace Deliverable_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade: ");

            try
            {

                decimal grade = decimal.Parse(Console.ReadLine());

                string letter;

                if (grade <= 60)
                {
                    letter = "F"; //this step is optional. You could omit this line and add a specific quote below
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter); // could be "is A" if not using letter
                }

                else if (grade >= 60 && grade < 70)
                {
                    letter = "D";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }

                else if (grade >= 70 && grade < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }

                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }

                else if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }
            }

            catch
            {
                Console.WriteLine("Please enter a numeric value.");
            }
        }
    }

}