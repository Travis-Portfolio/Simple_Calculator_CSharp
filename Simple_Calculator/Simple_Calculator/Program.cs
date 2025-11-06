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
            Console.WriteLine("Welcome to the C# calculator!");
            Console.WriteLine("Please enter two operands and an operator (+,-,*,/)");
            Console.WriteLine("Type EXIT to end the program");

            string userInput = Console.ReadLine();

            while(userInput != "EXIT")
            {
                // extract two operators and operands from user input.
                // use the operator symbol for the switch cases in the Calculate method.
                // modify Calculate method to simpy return the ints.
                Console.WriteLine("Answer");
                Console.WriteLine("Please enter next query");
                userInput = Console.ReadLine();
            }
        }

        static void Calculate(int x, int y, string function)
        {
            switch (function)
            {
                case "Add":
                    Console.WriteLine(Add(x, y));
                    break;
                case "Subtract":
                    Console.WriteLine(Subtract(x, y));
                    break;
                case "Multiply":
                    Console.WriteLine(Multiply(x, y));
                    break;
                case "Divide":
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
