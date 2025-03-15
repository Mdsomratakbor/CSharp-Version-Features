using System;

namespace CSharp8
{
    /// <summary>
    /// Default Interface Methods allow interfaces to have method implementations.
    /// Classes implementing the interface can either override these methods or use the default ones.
    /// </summary>
    public interface ILogger
    {
        void Log(string message); // Must be implemented by derived classes

        /// <summary>
        /// Default method implementation in an interface.
        /// Can be overridden by implementing classes.
        /// </summary>
        public void LogInfo(string message)
        {
            Console.WriteLine($"INFO: {message}");
        }
    }

    /// <summary>
    /// Implements ILogger but does not override LogInfo(), so it uses the default implementation.
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging message: {message}");
        }
    }

    /// <summary>
    /// Implements ILogger and overrides LogInfo() to provide a custom implementation.
    /// </summary>
    public class CustomLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Custom Log: {message}");
        }

        // Overriding the default method
        public void LogInfo(string message)
        {
            Console.WriteLine($"CUSTOM INFO: {message}");
        }
    }


    public interface IA
    {
        void Show() => Console.WriteLine("Interface A Default Method");
    }

    public interface IB
    {
        void Show() => Console.WriteLine("Interface B Default Method");
    }

    public class MyClass : IA, IB
    {
        // Resolving conflict by explicitly implementing the interfaces
        void IA.Show()
        {
            Console.WriteLine("Calling IA's default method:");
        }

        void IB.Show()
        {
            Console.WriteLine("Calling IB's default method:");
        }

        // Optionally, we can provide a new implementation
        public void Show()
        {
            Console.WriteLine("Resolved Method in MyClass");
        }
    }


    public static class DefaultInterfaceMethodsDemo
    {
        public static void Run()
        {
            ILogger logger1 = new ConsoleLogger();
            logger1.Log("This is a log message.");
            logger1.LogInfo("This is an info log."); // Uses default implementation

            Console.WriteLine();

            ILogger logger2 = new CustomLogger();
            logger2.Log("This is another log message.");
            logger2.LogInfo("This is an info log."); // Uses overridden method


            Console.WriteLine();

            MyClass obj = new MyClass();
            obj.Show();

            // Calling interface methods explicitly
            ((IA)obj).Show(); // Calls IA's method
            ((IB)obj).Show(); // Calls IB's method
        }
    }
}
