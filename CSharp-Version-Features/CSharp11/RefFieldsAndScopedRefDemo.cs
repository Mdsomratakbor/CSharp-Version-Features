namespace CSharp11;

/// <summary>
/// Demonstrates the usage of ref fields and scoped ref in C# 11.
/// Ref fields allow a reference to a variable to be modified directly, 
/// and scoped ref provides a safer, more controlled way to handle references within a method's scope.
/// </summary>
public static class RefFieldsAndScopedRefDemo
{
    /// <summary>
    /// Demonstrates the use of ref fields in C# 11.
    /// Ref fields allow you to store a reference to a variable, enabling direct modification of the original data.
    /// </summary>
    public static void RefFieldDemo()
    {
        int myValue = 10;
        ref int refField = ref myValue; // Create a ref field pointing to myValue

        // Print original value
        Console.WriteLine($"Original value: {myValue}");

        // Modify the value through the ref field
        refField = 50;

        // Print the modified value
        Console.WriteLine($"Modified value through ref field: {myValue}");
    }

    /// <summary>
    /// Demonstrates the use of scoped ref in C# 11.
    /// Scoped ref allows you to safely reference and modify variables within a specific scope.
    /// It ensures that references do not escape their valid scope, preventing unsafe behavior.
    /// </summary>
    public static void ScopedRefDemo()
    {
        int[] numbers = { 1, 2, 3 };

        // Create a scoped ref to the first element of the array
        ref int firstElement = ref numbers[0];

        // Print original value
        Console.WriteLine($"Before modification: {firstElement}");

        // Modify the value through the scoped ref
        firstElement = 100;

        // Print the modified value
        Console.WriteLine($"After modification: {firstElement}");

        // Print the modified array
        Console.WriteLine($"Array after modification: {numbers[0]}, {numbers[1]}, {numbers[2]}");
    }

    /// <summary>
    /// Runs both the RefFieldDemo and ScopedRefDemo methods to demonstrate the functionality of ref fields and scoped ref.
    /// </summary>
    public static void Run()
    {
        Console.WriteLine("Running RefFieldDemo:");
        RefFieldDemo();

        Console.WriteLine("\nRunning ScopedRefDemo:");
        ScopedRefDemo();
    }
}


