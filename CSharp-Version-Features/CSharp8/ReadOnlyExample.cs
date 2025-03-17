using System;

namespace CSharp8
{
    /// <summary>
    /// Readonly Members ensure that struct fields cannot be modified after initialization, making the struct immutable.
    /// - **Memory Usage**: Helps optimize memory by preventing unnecessary modifications.
    /// - **Time Complexity**: O(1) as it only reads a field.
    /// - **Performance Benefit**: Prevents struct copying in method calls.
    /// </summary>
    public struct ReadOnlyExample
    {
        public readonly int X;
        public ReadOnlyExample(int x) => X = x;

        /// <summary>
        /// A readonly method that only reads the field X.
        /// Readonly ensures no modifications occur inside the method.
        /// </summary>
        public readonly void PrintX() => Console.WriteLine($"Readonly X: {X}");
    }

    public static class ReadOnlyExampleDemo
    {
        public static void Run()
        {
            Console.WriteLine("=== Readonly Struct Example ===");
            ReadOnlyExample example = new ReadOnlyExample(42);
            example.PrintX();

            Console.WriteLine("\n=== Mutable Struct Example ===");
            Point p = new Point(2, 3);
            p.Print();

            p.Move(1, 1);  
            p.Print();

            Console.WriteLine("\n=== Readonly Struct (Immutable) Example ===");
            ReadOnlyPoint readOnlyP = new ReadOnlyPoint(2, 3);
            readOnlyP.Print();

            // readOnlyP.Move(1, 1); ❌ ERROR! ReadOnlyPoint is immutable
        }
    }

    /// <summary>
    /// A mutable struct that allows modifying fields.
    /// </summary>
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Non-readonly method modifies fields.
        /// </summary>
        public void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public void Print() => Console.WriteLine($"Point: ({X}, {Y})");
    }

    /// <summary>
    /// A readonly struct ensures immutability and prevents modifications.
    /// </summary>
    public readonly struct ReadOnlyPoint
    {
        public readonly int X;
        public readonly int Y;

        public ReadOnlyPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Readonly method that does not allow modifications.
        /// </summary>
        public readonly void Print() => Console.WriteLine($"ReadOnlyPoint: ({X}, {Y})");
    }
}


//[Note : Use a struct for small, immutable, memory-efficient value types, and a class for large, mutable objects requiring polymorphism or heap allocation.]