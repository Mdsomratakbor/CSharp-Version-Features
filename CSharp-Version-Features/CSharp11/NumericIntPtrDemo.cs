namespace CSharp11;

/// <summary>
/// Demonstrates the new numeric operations support for IntPtr in C# 11.
/// This includes arithmetic, bitwise operations, and increment/decrement.
/// </summary>
public static class NumericIntPtrDemo
{
    public static void Run()
    {
        IntPtr ptr1 = new IntPtr(10);
        IntPtr ptr2 = new IntPtr(20);

        // Arithmetic operations
        IntPtr sum = ptr1 + ptr2;
        IntPtr difference = ptr2 - ptr1;
        IntPtr product = ptr1 * new IntPtr(2);
        IntPtr division = ptr2 / new IntPtr(2);

        // Bitwise operations
        IntPtr bitwiseAnd = ptr1 & ptr2;
        IntPtr bitwiseOr = ptr1 | ptr2;
        IntPtr bitwiseXor = ptr1 ^ ptr2;

        // Increment and Decrement
        IntPtr incremented = ++ptr1;
        IntPtr decremented = --ptr2;

        // Output results
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Division: {division}");
        Console.WriteLine($"Bitwise AND: {bitwiseAnd}");
        Console.WriteLine($"Bitwise OR: {bitwiseOr}");
        Console.WriteLine($"Bitwise XOR: {bitwiseXor}");
        Console.WriteLine($"Incremented: {incremented}");
        Console.WriteLine($"Decremented: {decremented}");

        Console.WriteLine("==========================================================================================");
        RunBeforeCSharp11();
    }


    public static void RunBeforeCSharp11()
    {
        // Before C# 11: Manually converting IntPtr to int for arithmetic and bitwise operations
        IntPtr ptr1 = new IntPtr(10);
        IntPtr ptr2 = new IntPtr(20);

        // Arithmetic operations
        int sum = ptr1.ToInt32() + ptr2.ToInt32(); // Convert to int
        int difference = ptr2.ToInt32() - ptr1.ToInt32(); // Convert to int
        int product = ptr1.ToInt32() * 2; // Convert to int
        int division = ptr2.ToInt32() / 2; // Convert to int

        // Bitwise operations
        int bitwiseAnd = ptr1.ToInt32() & ptr2.ToInt32(); // Convert to int
        int bitwiseOr = ptr1.ToInt32() | ptr2.ToInt32(); // Convert to int
        int bitwiseXor = ptr1.ToInt32() ^ ptr2.ToInt32(); // Convert to int

        // Increment and Decrement
        ptr1 = new IntPtr(ptr1.ToInt32() + 1); // Convert to int, then increment
        ptr2 = new IntPtr(ptr2.ToInt32() - 1); // Convert to int, then decrement

        // Output results
        Console.WriteLine($"Before C# 11 - Sum: {sum}");
        Console.WriteLine($"Before C# 11 - Difference: {difference}");
        Console.WriteLine($"Before C# 11 - Product: {product}");
        Console.WriteLine($"Before C# 11 - Division: {division}");
        Console.WriteLine($"Before C# 11 - Bitwise AND: {bitwiseAnd}");
        Console.WriteLine($"Before C# 11 - Bitwise OR: {bitwiseOr}");
        Console.WriteLine($"Before C# 11 - Bitwise XOR: {bitwiseXor}");
        Console.WriteLine($"Before C# 11 - Incremented: {ptr1}");
        Console.WriteLine($"Before C# 11 - Decremented: {ptr2}");
    }
}
