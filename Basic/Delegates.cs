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


1. Factory Injection (a.k.a Factory Pattern with DI)

👉 In Dependency Injection (DI), usually you register a service and the DI container gives you back the same service whenever you request it.
But sometimes you don’t just want a fixed instance — you want to create objects on demand, possibly with different parameters.

That’s where Factory Injection comes in: you inject a factory (a function or delegate) instead of the actual instance.

Example without factory:
public class EmailService : IEmailService
{
    public void Send(string msg) => Console.WriteLine($"Email sent: {msg}");
}

public class NotificationManager
{
    private readonly IEmailService _emailService;

    public NotificationManager(IEmailService emailService) // fixed dependency
    {
        _emailService = emailService;
    }

    public void Notify(string msg)
    {
        _emailService.Send(msg);
    }
}


Here, NotificationManager is stuck with one EmailService provided by DI.

Example with factory injection:
public class NotificationManager
{
    private readonly Func<IEmailService> _emailServiceFactory;

    public NotificationManager(Func<IEmailService> emailServiceFactory) // factory injected
    {
        _emailServiceFactory = emailServiceFactory;
    }

    public void Notify(string msg)
    {
        var service = _emailServiceFactory(); // create new EmailService when needed
        service.Send(msg);
    }
}


➡️ This allows creating a fresh service each time or choosing different implementations if registered.

Custom Delegate

You create your own type (public delegate ...) when you want something strongly named and maybe more descriptive.

Example: public delegate int MathOperation(int x, int y);

Built-in Func / Action

Instead of creating custom delegates for everything, .NET provides generic delegates:

Func<in T, out TResult> → represents a method that takes input(s) and returns a value.

Action<in T> → represents a method that takes input(s) but returns void.

Example using Func instead of custom delegate:

Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(3, 5)); // 8


Example using Action:

Action<string> log = msg => Console.WriteLine($"Log: {msg}");
log("Hello");
