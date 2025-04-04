using System;

namespace CSharp13
{
    /// <summary>
    /// Demonstrates C# 13's "More Partial Members" feature.
    /// Allows splitting methods, properties, and fields across partial class definitions.
    /// </summary>
    public static class MorePartialMembersDemo
    {
        public static void Run()
        {
            Console.WriteLine("=== Partial Method Demo ===");
            var logger = new Logger();
            logger.Log("This is a partial method demo!");

            Console.WriteLine("\n=== Partial Property Demo ===");
            var user = new User();
            user.Name = "Md Samrat";
            Console.WriteLine($"User Name: {user.Name}");

            Console.WriteLine("\n=== Partial Field Demo ===");
            var data = new Data();
            Console.WriteLine($"Counter Value: {data.Counter}");
        }
    }

    // ----------------------------
    // Partial Method
    public partial class Logger
    {
        public partial void Log(string message); // Declaration
    }

    public partial class Logger
    {
        public partial void Log(string message) // Implementation
        {
            Console.WriteLine($"[Logger] {message}");
        }
    }

    // ----------------------------
    // Partial Property
    public partial class User
    {
        // Declare property without body
       public partial string Name { get; set; }
    }

    public partial class User
    {
        // implementation declaration:
    private string _name;
    public partial string Name
    {
        get => _name;
        set => _name = value;
    }
    }

    // ----------------------------
    // Partial Field
    public partial class Data
    {
        public  int Counter;
    }

    public partial class Data
    {
        // Assign value in constructor or field initializer
        public Data()
        {
            Counter = 42;
        }
    }
}
