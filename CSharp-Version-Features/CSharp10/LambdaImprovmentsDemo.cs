
namespace CSharp10;

public class LambdaImprovementsDemo
{
    /// <summary>
    /// Demonstrates the improvements in lambda expressions introduced in C# 10.
    /// C# 10 allows you to:
    /// 1. Explicitly define return types for lambda expressions.
    /// 2. Use nullable return types in lambda expressions.
    /// 3. Increase flexibility and clarity when working with lambdas.
    /// </summary>
    public static void Run()
    {
        // Example 1: Simple lambda expression with a non-nullable return type
        var helloWorld = () => "Hello World";
        Console.WriteLine(helloWorld());  // Output: Hello World

        // Example 2: Lambda expression returning a nullable string type
        var text = () => (string?)null; // In C# 10, nullable types can be directly used in lambdas.
        Console.WriteLine(text());  // Output: (null)

        // Example 3: Lambda expression with explicit return type
        Func<int> addTwoNumbers = () => 2 + 2;  // Explicitly returning an int
        Console.WriteLine(addTwoNumbers());  // Output: 4

        // Example 4: Lambda expression with a nullable return type and conditional logic
        // In C# 10, you can explicitly use nullable types and conditional checks in lambdas
        Func<int, string?> checkEvenOrNull = (number) => number % 2 == 0 ? "Even" : null;
        Console.WriteLine(checkEvenOrNull(4));  // Output: Even
        Console.WriteLine(checkEvenOrNull(5));  // Output: (null)

        // Example 5: Lambda expression using a tuple with nullable and non-nullable values
        Func<int, (string, string?)> processNumber = (number) =>
        {
            if (number % 2 == 0)
                return ("Even", null); // Non-nullable and nullable return value in tuple
            return ("Odd", "Special Case");
        };

        var result = processNumber(4);
        Console.WriteLine($"Number: 4, Type: {result.Item1}, Message: {result.Item2}");  // Output: Number: 4, Type: Even, Message: (null)

        var result2 = processNumber(5);
        Console.WriteLine($"Number: 5, Type: {result2.Item1}, Message: {result2.Item2}");  // Output: Number: 5, Type: Odd, Message: Special Case
    }

    /// <summary>
    /// Example lambdas with different scenarios:
    /// - A non-nullable return type
    /// - A nullable return type
    /// - Conditional logic in lambdas
    /// - Return tuples with nullable and non-nullable values
    /// </summary>

    // Simple lambda returning a non-nullable string
    Func<string> helloWorld = () => "Hello World";

    // Lambda returning a nullable string
    Func<string?> text = () => null;

    // Lambda with explicit return type
    Func<int> addTwoNumbers = () => 2 + 2;

    // Lambda with conditional logic and nullable return type
    Func<int, string?> checkEvenOrNull = (number) => number % 2 == 0 ? "Even" : null;

    // Lambda that returns a tuple containing nullable and non-nullable types
    Func<int, (string, string?)> processNumber = (number) =>
    {
        if (number % 2 == 0)
            return ("Even", null);
        return ("Odd", "Special Case");
    };
}
