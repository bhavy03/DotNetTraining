public class Calculator
{
    public delegate void ResultHandler(int result);

    public void Add(int a, int b, ResultHandler callback)
    {
        int sum = a + b;
        callback(sum); // Call the method passed in
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        // Pass a method as callback
        calc.Add(5, 10, PrintResult);
        calc.Add(7, 3, PrintDoubleResult);
    }

    static void PrintResult(int result)
    {
        Console.WriteLine("Result: " + result);
    }

    static void PrintDoubleResult(int result)
    {
        Console.WriteLine("Double Result: " + (result * 2));
    }
}
