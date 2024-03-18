using System;

namespace SampleProgram.src
{
    public interface IUserInput
    {
        string GetInput();
    }

    public class ConsoleUserInput : IUserInput
    {
        public string GetInput()
        {
            return Console.ReadLine().Trim();
        }
    }

    public class Calculator
    {
        private IUserInput _userInput;

        public Calculator(IUserInput userInput)
        {
            _userInput = userInput;
        }

        public void Start()
        {
            Console.WriteLine("Sample Program: Calculator(only addiiton and substraction)");
            Console.WriteLine("What do you want to do?");
            bool running = true;
            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the number of the action you want to perform:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Quit");
                Console.WriteLine();

                string input = _userInput.GetInput();
                switch (input)
                {
                    case "1":
                        PerformOperation(Addition);
                        break;
                    case "2":
                        PerformOperation(Subtraction);
                        break;
                    case "3":
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

        public (double, double) NumberInput()
        {
            double number1;
            double number2;

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter number 1: ");
                    number1 = Convert.ToDouble(_userInput.GetInput());
                    Console.WriteLine("Enter number 2: ");
                    number2 = Convert.ToDouble(_userInput.GetInput());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            return (number1, number2);
        }

        private void Subtraction(double number1, double number2)
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
