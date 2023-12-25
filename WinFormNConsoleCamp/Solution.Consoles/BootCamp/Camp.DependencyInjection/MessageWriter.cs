﻿namespace Camp.DependencyInjection;

public class MessageWriter : IMessageWriter
{
    public void Write(string message)
    {
        Console.WriteLine($"{message}");
    }
}
