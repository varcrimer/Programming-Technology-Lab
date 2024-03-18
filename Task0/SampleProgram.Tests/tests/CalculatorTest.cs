using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleProgram.src;
using System;
using System.IO;

namespace SampleProgram.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddition()
        {
            var userInput = new StringReader("1\n10\n5\n3\n");
            Console.SetIn(userInput);
            var calculator = new Calculator(new ConsoleUserInput());
            var expectedOutput = "Result: 15\r\n";

            var writer = new StringWriter();
            Console.SetOut(writer);
            calculator.Start();
            var actualOutput = writer.ToString();

            Assert.IsTrue(actualOutput.Contains(expectedOutput));
        }

        [TestMethod]
        public void TestSubstraction()
        {
            var userInput = new StringReader("2\n10\n5\n3\n");
            Console.SetIn(userInput);
            var calculator = new Calculator(new ConsoleUserInput());

            var expectedOutput = "Result: 5\r\n";
            var writer = new StringWriter();
            Console.SetOut(writer);
            calculator.Start();
            var actualOutput = writer.ToString();

            Assert.IsTrue(actualOutput.Contains(expectedOutput));
        }
    }
}
