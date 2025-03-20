using System.Numerics;

namespace CSharp11;

/// <summary>
/// Demonstrates the usage of Generic Math Support introduced in C# 11.
/// Key features include:
/// - Static virtual members in interfaces
/// - Checked user-defined operators
/// - Relaxed shift operators
/// - Unsigned right-shift operator
/// </summary>
public static class GenericMathSupportDemo
{
    public static void Run()
    {

        Console.WriteLine("Generic Math Support Demo:");

        // Using generic Add method
        Console.WriteLine($"Sum of integers: {Add(10, 20)}");
        Console.WriteLine($"Sum of doubles: {Add(5.5, 3.2)}");
        Console.WriteLine($"Sum of decimals: {Add(100.75m, 50.25m)}");

        // Using Shift Operators
        Console.WriteLine($"Left shift (10 << 2): {ShiftLeft(10, 2)}");
        Console.WriteLine($"Unsigned right shift (10 >>> 1): {UnsignedRightShift(10, 1)}");


        Console.WriteLine("🔢 Static Virtual Members in Interfaces Demo:");

        CustomNumber a = new(20);
        CustomNumber b = new(5);

        Console.WriteLine($"✅ Addition: {a} + {b} = {a + b}");
        Console.WriteLine($"✅ Subtraction: {a} - {b} = {a - b}");
        Console.WriteLine($"✅ Multiplication: {a} * {b} = {a * b}");
        Console.WriteLine($"✅ Division: {a} / {b} = {a / b}");

        try
        {
            CustomNumber zero = new(0);
            Console.WriteLine($"❌ Division by Zero: {a} / {zero} = {a / zero}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"⚠️ Exception: {ex.Message}");
        }
    }

    /// <summary>
    /// Adds two numbers of a generic numeric type using C# 11's generic math feature.
    /// </summary>
    /// <typeparam name="T">A numeric type that supports addition.</typeparam>
    /// <param name="a">The first number.</param>
    /// <param name="b">The second number.</param>
    /// <returns>The sum of the two numbers.</returns>
    public static T Add<T>(T a, T b) where T : INumber<T>
    {
        return a + b;
    }

    /// <summary>
    /// Performs a left shift operation on a numeric value.
    /// </summary>
    public static T ShiftLeft<T>(T value, int shiftAmount) where T : IBinaryInteger<T>
    {
        return value << shiftAmount;
    }

    /// <summary>
    /// Performs an unsigned right shift operation on a numeric value.
    /// </summary>
    public static T UnsignedRightShift<T>(T value, int shiftAmount) where T : IBinaryInteger<T>
    {
        return value >>> shiftAmount; // C# 11 unsigned right shift operator
    }
}


/// <summary>
/// Defines a mathematical interface with static virtual members.
/// Enables generic numeric computations.
/// </summary>
/// <typeparam name="T">The implementing type.</typeparam>
public interface IArithmetic<T> where T : IArithmetic<T>
{
    // Static abstract operator for addition
    static abstract T operator +(T left, T right);

    // Static abstract operator for subtraction
    static abstract T operator -(T left, T right);

    // Static abstract operator for multiplication
    static abstract T operator *(T left, T right);

    // Static abstract operator for division
    static abstract T operator /(T left, T right);
}

/// <summary>
/// Represents a custom numeric type that implements IArithmetic.
/// </summary>
public struct CustomNumber : IArithmetic<CustomNumber>
{
    public int Value { get; }

    public CustomNumber(int value) => Value = value;

    // Implementing addition
    public static CustomNumber operator +(CustomNumber left, CustomNumber right) =>
        new(left.Value + right.Value);

    // Implementing subtraction
    public static CustomNumber operator -(CustomNumber left, CustomNumber right) =>
        new(left.Value - right.Value);

    // Implementing multiplication
    public static CustomNumber operator *(CustomNumber left, CustomNumber right) =>
        new(left.Value * right.Value);

    // Implementing division (handling division by zero)
    public static CustomNumber operator /(CustomNumber left, CustomNumber right) =>
        right.Value == 0 ? throw new DivideByZeroException("Cannot divide by zero") : new(left.Value / right.Value);

    public override string ToString() => Value.ToString();
}
