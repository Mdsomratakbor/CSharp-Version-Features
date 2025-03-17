using System;

namespace CSharp9
{
    /// <summary>
    /// Demonstrates the usage of init-only setters in C# 9.0.
    /// Init-only properties allow values to be set only during object initialization,
    /// enhancing immutability while maintaining flexibility in object creation.
    /// </summary>
    public static class InitOnlySettersDemo
    {
        public static void Run()
        {
            // Creating an immutable Person object using init-only properties
            var developer = new Developer { Name = "John Doe", Age = 30 };

            Console.WriteLine($"Developer: {developer.Name}, Age: {developer.Age}");

            // developer.Name = "Jane Doe"; // ❌ Error: Cannot modify 'init' only property
        }
    }

    /// <summary>
    /// Represents a developer with init-only properties, ensuring immutability after initialization.
    /// </summary>
    public class Developer
    {
        public string Name { get; init; }
        public int Age { get; init; }
    }
}
