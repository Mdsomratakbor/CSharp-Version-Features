using System;

namespace CSharp13
{
    /// <summary>
    /// Demonstrates the "Method Group Natural Type Improvements" feature in C# 13.
    /// This feature allows passing method groups without explicitly specifying the delegate type
    /// when the compiler can naturally infer the type.
    /// </summary>
    public static class MethodGroupNaturalTypeImprovements
    {
        public static void Run()
        {
            Console.WriteLine("=== Example 1: Using Method Group with Implicit Delegate Type ===");
            // After C# 13, we can pass method groups without specifying the delegate type.
            // The compiler infers the delegate type automatically.
            ExecuteAction(PrintMessage); // C# 13 will infer the Action<string> delegate type

            Console.WriteLine("\n=== Example 2: Passing Method Group to LINQ ===");
            // C# 13 makes it easier to pass method groups directly to LINQ methods.
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(Square); // C# 13 automatically infers the Func<int, int>
            Console.WriteLine("Squared numbers: " + string.Join(", ", squaredNumbers));

            // Console.WriteLine("\n=== Example 3: Using Method Group in Sorting ===");
            // // Method groups can also be used for sorting with LINQ's OrderBy method.
            // var fruits = new List<string> { "Banana", "Apple", "Orange", "Pineapple" };
            // var sortedFruits = fruits.AsQueryable().OrderBy<string, int>(CompareLength); // No need to explicitly define Func<string, string, int>
            // Console.WriteLine("Sorted fruits: " + string.Join(", ", sortedFruits));
        }

        // Example 1: Print message method
        public static void PrintMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        // Example 2: Square method for LINQ
        public static int Square(int number)
        {
            return number * number;
        }

        // Example 3: Method to compare string lengths for sorting
        public static int CompareLength(string str1, string str2)
        {
            return str1.Length.CompareTo(str2.Length);
        }

        // Helper method to execute an action with a string argument
        public static void ExecuteAction(Action<string> action)
        {
            action("This is a method group demo!");
        }
    }
}
