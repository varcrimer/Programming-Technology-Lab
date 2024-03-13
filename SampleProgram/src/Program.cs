using SampleProgram.src;

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator(new ConsoleUserInput());
        calculator.Start();
    }
}