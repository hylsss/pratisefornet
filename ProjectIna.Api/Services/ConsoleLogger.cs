using System;
namespace ProjectIna.Services;

public class ConsoleLogger:ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logged: {message}");
    }
}