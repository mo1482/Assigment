using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Timers;
using static Program;

class Program
{
    static void Main()
    {
        bool continueCalculating = true;

        while (continueCalculating)
        {
            double number1;
            double number2;

            Console.WriteLine("=== Calculator ===");

            Console.Write("Enter the first number: ");
            while (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.Write("Invalid input. Enter a valid number: ");
            }

            Console.Write("Enter the second number: ");
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.Write("Invalid input. Enter a valid number: ");
            }

            Console.Write("Choose operation (+, -, *, /): ");
            string operation = Console.ReadLine() ?? "";

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Result = {number1 + number2}");
                    break;

                case "-":
                    Console.WriteLine($"Result = {number1 - number2}");
                    break;

                case "*":
                    Console.WriteLine($"Result = {number1 * number2}");
                    break;

                case "/":
                    if (number2 == 0)
                        Console.WriteLine("Error: Cannot divide by zero.");
                    else
                        Console.WriteLine($"Result = {number1 / number2}");
                    break;

                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }

            Console.Write("\nDo another calculation? (yes/no): ");
            string answer = Console.ReadLine() ?? "";

            continueCalculating =
                answer.Equals("yes", StringComparison.OrdinalIgnoreCase) ||
                answer.Equals("y", StringComparison.OrdinalIgnoreCase);

            Console.WriteLine();
        }
    }
}