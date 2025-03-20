using System.Diagnostics;
namespace CSharp11;

/// <summary>
/// Demonstrates the Extended Nameof Scope feature in C# 11 compared to previous versions.
/// This feature allows the 'nameof' operator to be used in parameter default values,
/// attributes, and other contexts where it was not previously supported.
/// </summary>
public static class ExtendedNameofScopeDemo
{
    /// <summary>
    /// Runs the demonstration of the extended 'nameof' scope feature.
    /// </summary>
    public static void Run()
    {
        PrintParameter();
        Console.WriteLine($"Class name: {nameof(ExtendedNameofScopeDemo)}");
        Console.WriteLine($"Method name: {nameof(Run)}");
        Console.WriteLine($"Property name: {nameof(SampleProperty)}");
        NameofDemoOld.Run();
    }

    /// <summary>
    /// Demonstrates using 'nameof' in a method parameter default value (C# 11 feature).
    /// </summary>
    /// <param name="param">A string parameter with a default value using 'nameof'.</param>
    public static void PrintParameter(string param = nameof(PrintParameter))
    {
        Console.WriteLine($"Parameter value: {param}");
    }

    /// <summary>
    /// A sample property to demonstrate 'nameof' in property context.
    /// </summary>
    public static string SampleProperty { get; set; } = nameof(SampleProperty);

    /// <summary>
    /// Demonstrates using 'nameof' in an attribute (C# 11 feature).
    /// </summary>
    [System.Diagnostics.Conditional(nameof(Debug))]
    public static void DebugMethod()
    {
        Console.WriteLine("This method is only compiled in debug mode.");
    }


  
}
// Comparison: Before C# 11
public static class NameofDemoOld
{
    public static void Run()
    {
        PrintParameter();
        Console.WriteLine($"Class name: {nameof(NameofDemoOld)}");
        Console.WriteLine($"Method name: {nameof(Run)}");
        Console.WriteLine($"Property name: {nameof(SampleProperty)}");
    }

    public static void PrintParameter(string param = "PrintParameter") // Hardcoded string before C# 11
    {
        Console.WriteLine($"Parameter value: {param}");
    }

    public static string SampleProperty { get; set; } = "SampleProperty"; // Hardcoded string before C# 11

    // Before C# 11, 'nameof' was not allowed in attributes.
    //[System.Diagnostics.Conditional(nameof(DEBUG))] // Not valid in C# 10
    public static void DebugMethod()
    {
        Console.WriteLine("This method is only compiled in debug mode.");
    }
}