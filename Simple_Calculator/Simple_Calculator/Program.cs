using System.Text.RegularExpressions;
using System.Transactions;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartMenu();

            // Our basic functions only perform operations on integers.

            // Simple version of taking user input. Want to make this
            // a single line of input like "3 + 4" and use the operator
            // for the switch statement, so it's more like a real calculator.
           
        }

        static void StartMenu()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("Welcome to the C# calculator!");
            Console.WriteLine("Please enter two operands separated by an operator (+,-,*,/)");
            // Make EXIT case insensitive
            Console.WriteLine("Type EXIT to end the program");
            Console.WriteLine("============================================================");
            Console.WriteLine();

            InputHandling();
        }

        static void InputHandling()
        {
            // Change regex to take negative ints too
            string pattern = @"^\s*\d+\s*[+\-*/]\s*\d+\s*$";

            string userInput = Console.ReadLine();

            while(userInput != "EXIT")
            {
                if(Regex.IsMatch(userInput, pattern))
                {
                    // extract two operators and an operand from user input.
                    string[] inputValues = Regex.Split(userInput.Trim(), @"\s+");
                    // Need to handle inputs like 5+2 without spaces
                    int value1 = int.Parse(inputValues[0]);
                    int value2 = int.Parse(inputValues[2]);
                    string operation = inputValues[1];

                    
                    int answer = Calculate(value1, value2, operation);
                    FormattedOutput(value1, value2, operation, answer );
                } else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Example input 5 + 2");
                    Console.WriteLine();
                }
                Console.WriteLine("Please enter next query");
                Console.WriteLine();
                userInput = Console.ReadLine();
            }
        }

        static void FormattedOutput(int x, int y,  string operation, int answer)
        {
            Console.WriteLine();
            Console.WriteLine($"{x} {operation} {y} = {answer}");
            Console.WriteLine();
        }

        static int Calculate(int x, int y, string function)
        {
            switch (function)
            {
                case "+":
                    return Add(x, y);
                    break;
                case "-":
                    return Subtract(x, y);
                    break;
                case "*":
                    return Multiply(x, y);
                    break;
                case "/":
                    return Divide(x, y);
                    break;
                default:
                    // technically unreachable due to input validation. -1 serves as a placeholder
                    return -1;
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
