
namespace CSharp11;

public static class MethodGroupDemo
{
    /// <summary>
    /// Processes a message by invoking the provided Action delegate.
    /// This method is an older approach before C# 11 improved method group conversions.
    /// </summary>
    /// <param name="action">An Action delegate that processes the message.</param>
    public static void ProcessMessageOld(Action<string> action)
    {
        action("Hello from C# 10!");
    }

    /// <summary>
    /// A method to be used as a delegate that prints a message to the console.
    /// This is the old version of the method before C# 11.
    /// </summary>
    /// <param name="message">The message to be printed.</param>
    public static void PrintMessageOld(string message)
    {
        Console.WriteLine(message);
    }

    /// <summary>
    /// Processes a message by invoking the provided Action delegate.
    /// This is the updated approach in C# 11, which improves method group conversion.
    /// </summary>
    /// <param name="action">An Action delegate that processes the message.</param>
    public static void ProcessMessage(Action<string> action)
    {
        action("Hello from C# 11!");
    }

    /// <summary>
    /// A method to be used as a delegate that prints a message to the console.
    /// This is the new version after C# 11, where method group conversion is improved.
    /// </summary>
    /// <param name="message">The message to be printed.</param>
    public static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    /// <summary>
    /// Runs the examples demonstrating both old and new approaches for method group conversion to delegates.
    /// </summary>
    public static void Run()
    {
        // Using improved method group conversion (C# 11)
        ProcessMessage(PrintMessage); // Implicit delegate

        // Using the old method group conversion with explicit delegate (pre-C# 11)
        ProcessMessageOld(new Action<string>(PrintMessageOld)); // Explicit delegate
    }
}
