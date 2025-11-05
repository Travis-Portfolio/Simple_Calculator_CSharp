using System.Transactions;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Our basic functions only perform operations on integers.

            // Simple version of taking user input. Want to make this
            // a single line of input like "3 + 4" and use the operator
            // for the switch statement, so it's more like a real calculator.
            Console.WriteLine("Enter first value");
            int userInputValue1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value");
            int userInputValue2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation to perform");
            string userInputOperation = Console.ReadLine();

            Calculate(userInputValue1, userInputValue2, userInputOperation);
            Calculate(4, 3, "Subtract"); //expect 1
            Calculate(5, 3, "Multiply"); // expect 15
            Calculate(8, 4, "Divide"); // expect 2
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
