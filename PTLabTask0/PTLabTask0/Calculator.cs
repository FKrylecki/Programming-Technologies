namespace PTLabTask0
{
    public class Calculator
    {
        public double add(double x, double y)
        {
            return x + y;
        }

        public double subtract(double x, double y)
        {
            return x - y;
        }

        public double divide(double x, double y)
        {
            return x / y;
        }

        public double multiply(double x, double y)
        {
            return x * y;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.add(1, 2));
        }
    }
}