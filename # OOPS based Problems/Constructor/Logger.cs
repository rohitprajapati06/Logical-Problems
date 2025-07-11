using System;

public sealed class Logger
{
    private static Logger _instance;

    private Logger()
    {
        Console.WriteLine("Logger instance created.");
    }

    public static Logger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Logger();
        }
        return _instance;
    }

    // Example method
    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}

class Program
{
    static void Main()
    {
        Logger logger1 = Logger.GetInstance();
        Logger logger2 = Logger.GetInstance();

        Console.WriteLine($"Are logger1 and logger2 the same? {ReferenceEquals(logger1, logger2)}");

        logger1.Log("First log message");
        logger2.Log("Second log message");
    }
}
