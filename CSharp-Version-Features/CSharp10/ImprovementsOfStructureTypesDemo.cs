namespace CSharp10;

/// <summary>
/// This class demonstrates the improvements made to structure types in C# 10 using a Rectangle struct.
/// It highlights features like parameterless constructors, static members, and readonly struct enhancements.
/// </summary>
public class ImprovementsOfStructureTypesDemo
{
    /// <summary>
    /// This method demonstrates the usage of improved structure types in C# 10 using a Rectangle struct.
    /// </summary>
    public static void Run()
    {
        // 1. Demonstrating the automatic parameterless constructor in structs.
        Rectangle rectangle1 = new Rectangle(); // No need to manually define the parameterless constructor.
        Console.WriteLine($"Rectangle1: Length = {rectangle1.Length}, Width = {rectangle1.Width}");

        // 2. Demonstrating the use of static members in structs.
        Rectangle.PrintDefaultRectangle(); // Accessing static method in struct.

        // 3. Demonstrating a readonly struct with immutability.
        var rectangle2 = new Rectangle(5, 10);
        Console.WriteLine($"Rectangle2: Length = {rectangle2.Length}, Width = {rectangle2.Width}");

        // Attempting to modify a readonly struct will result in a compile-time error.
        // rectangle2.Length = 20; // Uncommenting this line will give an error because rectangle2 is readonly.
    }
}

/// <summary>
/// A simple structure demonstrating the use of static members, default constructor, and readonly fields in C# 10.
/// </summary>
public readonly struct Rectangle
{
    public int Length { get; }
    public int Width { get; }

    // Static member to hold the default rectangle (e.g., 0 x 0).
    public static Rectangle DefaultRectangle = new Rectangle(0, 0);

    // Constructor to initialize the struct with Length and Width values
    public Rectangle(int length, int width)
    {
        Length = length;
        Width = width;
    }
    // Static method to print the default rectangle's dimensions.
    public static void PrintDefaultRectangle()
    {
        Console.WriteLine($"Default Rectangle: Length = {DefaultRectangle.Length}, Width = {DefaultRectangle.Width}");
    }

    // Method to calculate the area of the rectangle
    public int CalculateArea()
    {
        return Length * Width;
    }
}
