using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProgram.src
{    public class Calculator1
    {
        public void Start()
        {
            Console.WriteLine("Welcome to the Basic Calculator Program!");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Quit");

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        PerformAddition();
                        break;
                    case "2":
                        PerformSubtraction();
                        break;
                    case "3":
                        PerformMultiplication();
                        break;
                    case "4":
                        PerformDivision();
                        break;
                    case "5":
                        Quit();
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }

        private void PerformAddition()
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 + num2;
            Console.WriteLine($"Result: {result}");
        }

        private void PerformSubtraction()
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 - num2;
            Console.WriteLine($"Result: {result}");
        }

        private void PerformMultiplication()
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 * num2;
            Console.WriteLine($"Result: {result}");
        }

        private void PerformDivision()
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero.");
                return;
            }

            double result = num1 / num2;
            Console.WriteLine($"Result: {result}");
        }

        private void Quit()
        {
            Console.WriteLine("Quitting the calculator program...");
        }
    }
}
