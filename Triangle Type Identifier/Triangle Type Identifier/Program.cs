using System;

namespace Triangle_Type_Identifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle Type Identifier");

            Console.Write("Enter side 1: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter side 2: ");
            string input2 = Console.ReadLine();

            Console.Write("Enter side 3: ");
            string input3 = Console.ReadLine();

            // Declare variables first
            int side1 = 0, side2 = 0, side3 = 0;

            // Parse all three inputs safely
            bool valid = int.TryParse(input1, out side1) &&
                         int.TryParse(input2, out side2) &&
                         int.TryParse(input3, out side3);

            if (!valid || side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                Console.WriteLine("Invalid input. Please enter positive numbers.");
                return;
            }

            // Check if the sides form a valid triangle
            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
            {
                Console.WriteLine("The values do not form a valid triangle.");
                return;
            }

            // Determine triangle type
            if (side1 == side2 && side2 == side3)
                Console.WriteLine("Triangle Type: Equilateral");
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("Triangle Type: Isosceles");
            else
                Console.WriteLine("Triangle Type: Scalene");
        }
    }
}
