using System.Text.RegularExpressions;
using System.Transactions;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Only works for integers
            StartMenu();
           
        }

        static void StartMenu()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("Welcome to The C# Integer Calculator!");
            Console.WriteLine("Please enter two operands separated by an operator (+,-,*,/)");
            Console.WriteLine("Type exit to end the program");
            Console.WriteLine("============================================================");
            Console.WriteLine();

            InputHandling();
        }

        static void InputHandling()
        {
            string userInput = Console.ReadLine().ToLower();

            while (userInput != "exit")
            {
                var pattern = Regex.Match(userInput.Trim(), @"^\s*(-?\d+)\s*([+\-*/])\s*(-?\d+)\s*$");

                if (pattern.Success)
                {
                    // extract two operators and an operand from user input.
                    int value1 = int.Parse(pattern.Groups[1].Value);
                    int value2 = int.Parse(pattern.Groups[3].Value);
                    string operation = pattern.Groups[2].Value;

                    
                    int answer = Calculate(value1, value2, operation);
                    FormattedOutput(value1, value2, operation, answer );
                } else
                {
                    InvalidInputMessage();
                }
                Console.WriteLine("Please enter next query:");
                Console.WriteLine();
                userInput = Console.ReadLine().ToLower();
            }
            ExitMessage();
        }

        static void InvalidInputMessage()
        {
            Console.WriteLine();
            Console.WriteLine("************************************************************");
            Console.WriteLine();
            Console.WriteLine("Invalid input. Try again. Example input 5 + 2");
            Console.WriteLine();
            Console.WriteLine("************************************************************");
            Console.WriteLine();
        }
        static void ExitMessage()
        {
            Console.WriteLine();
            Console.WriteLine("============================================================");
            Console.WriteLine("Thank you for using The C# Integer Calculator!");
            Console.WriteLine("GOODBYE!");
            Console.WriteLine("============================================================");
            Console.WriteLine();
        }

        static void FormattedOutput(int x, int y,  string operation, int answer)
        {
            Console.WriteLine();
            Console.WriteLine("############################################################");
            Console.WriteLine();
            Console.WriteLine($"Answer: {x} {operation} {y} = {answer}");
            Console.WriteLine();
            Console.WriteLine("############################################################");
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
