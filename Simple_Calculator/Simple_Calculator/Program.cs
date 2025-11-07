using System.Text.RegularExpressions;
using System.Transactions;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            startCalculator();

            // Our basic functions only perform operations on integers.

            // Simple version of taking user input. Want to make this
            // a single line of input like "3 + 4" and use the operator
            // for the switch statement, so it's more like a real calculator.
           
        }

        static void startCalculator()
        {
            // may want to separate some of this logic out, this method may be doing too much.
            Console.WriteLine("Welcome to the C# calculator!");
            Console.WriteLine("Please enter two operands separated by an operator (+,-,*,/)");
            Console.WriteLine("Type EXIT to end the program");

            string pattern = @"^\s*\d+\s*[+\-*/]\s*\d+\s*$";

            string userInput = Console.ReadLine();

            while(userInput != "EXIT")
            {
                if(Regex.IsMatch(userInput, pattern))
                {
                    // extract two operators and an operand from user input.
                    string[] inputValues = Regex.Split(userInput.Trim(), @"\s+");
                    int value1 = int.Parse(inputValues[0]);
                    int value2 = int.Parse(inputValues[2]);
                    string operation = inputValues[1];

                    // modify Calculate method to simpy return the ints?
                    Calculate(value1, value2, operation);
                } else
                {
                    Console.WriteLine("Invalid input. Example input 5 + 2");
                }
                Console.WriteLine("Please enter next query");
                userInput = Console.ReadLine();
            }
        }

        static void Calculate(int x, int y, string function)
        {
            switch (function)
            {
                case "+":
                    Console.WriteLine(Add(x, y));
                    break;
                case "-":
                    Console.WriteLine(Subtract(x, y));
                    break;
                case "*":
                    Console.WriteLine(Multiply(x, y));
                    break;
                case "/":
                    Console.WriteLine(Divide(x, y));
                    break;
                default:
                    Console.WriteLine("Function not recognized");
                    break;
            }
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }

    }
}
