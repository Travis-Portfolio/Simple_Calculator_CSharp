namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Our basic functions only perform operations on integers.
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Subtract(1, 2));
            Console.WriteLine(Multiply(1, 2));
            Console.WriteLine(Divide(1, 2));
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
