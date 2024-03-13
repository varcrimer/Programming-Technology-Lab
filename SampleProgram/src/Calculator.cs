using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProgram.src
{
    public class Calculator
    {
        public void Start()
        {
            Console.WriteLine("Sample Program: Calculator");
            Console.WriteLine("What do you want to do?)");
            bool running = true;
            while (running)
            {
                Console.WriteLine ("Enter the number of the action you want to perform:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Quit");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        PerformOperation(Addition);
                        break;
                    case "2":
                        PerformOperation(Substraction);
                        break;
                    case "3":
                        PerformOperation(Multiplication);
                        break;
                    case "4":
                        PerformOperation(Division);
                        break;
                    case "5":
                        Console.WriteLine("See you soon!!");
                        Console.WriteLine("Quitting Calculator...");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }  
        }

       private void PerformOperation(Action<double, double> operation)
        {
            (double number1, double number2) = NumberInput();
            operation(number1, number2);
        }
        private (double,double) NumberInput()
        {
            double number1;
            double number2;

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter number 1: ");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter number 2: ");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input!");

                }
            }
                return (number1, number2);
        }
    
        private void Division(double number1, double number2)
        {
            if (number2 == 0){
                Console.WriteLine("Pamiętaj cholero, nie dziel przez zero!!");
                return;
            };
            double result = number1 / number2;
            Console.WriteLine($"Result: {result}");
        }

        private void Multiplication(double number1, double number2)
        {
            double result = number1 * number2;
            Console.WriteLine($"Result: {result}");
        }

        private void Substraction(double number1, double number2)
        {
            double result = number1 - number2;
            Console.WriteLine($"Result: {result}");
        }

        private void Addition(double number1, double number2)
        {
            double result = number1 + number2;
            Console.WriteLine($"Result: {result}");
        }
    }
}
