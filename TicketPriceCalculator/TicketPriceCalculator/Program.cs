using System;

namespace TicketPriceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ticket Price Calculator");

            Console.Write("Enter your age: ");
            string userAge = Console.ReadLine();

            bool isAgeValid = int.TryParse(userAge, out int age);

            if (!isAgeValid || age < 0)
            {
                Console.WriteLine("Invalid age. Please enter a valid number.");
                return;
            }

            int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;

            Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
        }
    }
}
