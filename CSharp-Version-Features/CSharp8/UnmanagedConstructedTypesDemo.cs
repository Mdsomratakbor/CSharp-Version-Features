using System;
using System.Runtime.InteropServices;

namespace CSharp8
{
    /// <summary>
    /// Demonstrates unmanaged constructed types introduced in C# 8.0.
    /// Allows generic structs with unmanaged constraints to be used safely in low-level memory operations.
    /// </summary>
    public static class UnmanagedConstructedTypesDemo
    {
        /// <summary>
        /// A generic struct with an `unmanaged` constraint.
        /// This ensures that `T` is a value type with no managed references.
        /// </summary>
        public struct DataHolder<T> where T : unmanaged
        {
            public T Value;

            public DataHolder(T value)
            {
                Value = value;
            }
        }

        /// <summary>
        /// Demonstrates using unmanaged constructed types with memory allocation.
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("🔹 Unmanaged Constructed Types in Action:");

            //  Allowed: Using int (primitive unmanaged type)
            DataHolder<int> intHolder = new DataHolder<int>(42);
            Console.WriteLine($"Integer value: {intHolder.Value}");

            //  Allowed: Using struct with only unmanaged types
            DataHolder<CordinatePoint> pointHolder = new DataHolder<CordinatePoint>(new CordinatePoint(10, 20));
            Console.WriteLine($"Point value: {pointHolder.Value}");

            //  Not allowed: DataHolder<string> (string is a managed reference type)

            //  Working with memory allocation (using unmanaged types)
            AllocateAndPrintMemory<int>(100);
        }

        /// <summary>
        /// Allocates and prints a block of unmanaged memory for an array of `T`.
        /// </summary>
        /// <typeparam name="T">An unmanaged type.</typeparam>
        /// <param name="size">Number of elements to allocate.</param>
        public static unsafe void AllocateAndPrintMemory<T>(int size) where T : unmanaged
        {
            Console.WriteLine("\n🔹 Allocating Unmanaged Memory:");

            T* ptr = (T*)Marshal.AllocHGlobal(size * sizeof(T)); // Allocate unmanaged memory

            for (int i = 0; i < size; i++)
                ptr[i] = default; // Initialize with default values
            Console.WriteLine($"Allocated {size} elements of {typeof(T).Name} in unmanaged memory.");

            Marshal.FreeHGlobal((IntPtr)ptr); // Free unmanaged memory
            Console.WriteLine("✅ Memory released.");
        }
    }

    /// <summary>
    /// A struct containing only unmanaged types (int).
    /// </summary>
    public struct CordinatePoint
    {
        public int X;
        public int Y;

        public CordinatePoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"({X}, {Y})";
    }
}
