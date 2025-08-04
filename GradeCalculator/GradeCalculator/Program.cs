using System;

namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grade Calculator");

            Console.Write("Enter your grade (0 - 100): ");
            string userGrade = Console.ReadLine();

            bool isGradeValid = int.TryParse(userGrade, out int grade);

            if (!isGradeValid || grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                return;
            }

            string letterGrade;

            if (grade >= 90)
                letterGrade = "A";
            else if (grade >= 80)
                letterGrade = "B";
            else if (grade >= 70)
                letterGrade = "C";
            else if (grade >= 60)
                letterGrade = "D";
            else
                letterGrade = "F";

            Console.WriteLine($"Your letter grade is: {letterGrade}");
        }
    }
}
