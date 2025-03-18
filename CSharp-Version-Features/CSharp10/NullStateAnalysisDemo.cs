#nullable enable
namespace CSharp10;

/// <summary>
/// Demonstrates the improvements in definite assignment and null-state analysis in C# 10.
/// </summary>
public class NullStateAnalysis
{
    private readonly string _name; // Warning: Field '_name' is not initialized.

    /// <summary>
    /// Constructor without initializing _name, leading to a warning.
    /// </summary>
    public NullStateAnalysis()
    {
        // _name is not assigned, which leads to a compiler warning in C# 10.
    }

    /// <summary>
    /// Constructor with correct initialization, avoiding warnings.
    /// </summary>
    /// <param name="name">The name to initialize.</param>
    public NullStateAnalysis(string name)
    {
        _name = name; // No warning, as _name is now properly initialized.
    }

    /// <summary>
    /// A method demonstrating improved null-state analysis.
    /// </summary>
    public void PrintName()
    {
        Console.WriteLine(_name); // Potential warning if _name is not initialized.
    }
}

public static class NullStateAnalysisDemo
{
    public static void Run()
    {
        NullStateAnalysis obj = new NullStateAnalysis();
        obj.PrintName(); // May cause a warning or runtime issue if _name is not initialized.
    }
}
