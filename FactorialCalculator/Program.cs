namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringCalculator calculator = new StringCalculator();
            Console.WriteLine(calculator.Add("5, 6,3"));
        }
    }
}