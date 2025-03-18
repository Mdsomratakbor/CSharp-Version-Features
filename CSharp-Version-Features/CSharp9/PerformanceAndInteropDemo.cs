using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CSharp9
{
    /// <summary>
    /// Demonstrates performance and interoperability features introduced in C# 9.
    /// Features covered:
    /// - Native Sized Integers (nint, nuint)
    /// - Function Pointers (delegate* syntax)
    /// - Suppress Emitting LocalsInit Flag (SkipLocalsInit)
    /// - Module Initializers (ModuleInitializer)
    /// - New Features for Partial Methods
    /// </summary>
    public static class PerformanceAndInteropDemo
    {
        /// <summary>
        /// Executes all feature demonstrations.
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Performance and Interop Features Demo\n");

            // Demonstrating native-sized integers
            NativeIntExample();

            // Demonstrating function pointers (Requires unsafe context)
            UnsafeFunctionPointerExample();

            // Demonstrating suppression of localsinit flag
            SkipLocalsInitExample();

            // Demonstrating new features for partial methods
            PartialMethodExample();
        }

        /// <summary>
        /// Demonstrates the use of native-sized integers (nint, nuint).
        /// These types adapt to the platform (32-bit or 64-bit).
        /// </summary>
        static void NativeIntExample()
        {
            nint signedInt = 42;
            nuint unsignedInt = 42;

            Console.WriteLine($"Native Sized Integers:");
            Console.WriteLine($"Signed Native Int: {signedInt}");
            Console.WriteLine($"Unsigned Native Int: {unsignedInt}\n");
        }

        /// <summary>
        /// Demonstrates the use of function pointers in an unsafe block.
        /// Function pointers allow direct calling of unmanaged functions for performance.
        /// </summary>
        unsafe static void UnsafeFunctionPointerExample()
        {
            // Declare a function pointer
            delegate*<int, int, int> functionPointer = &Add;

            int result = functionPointer(10, 20);
            Console.WriteLine($"Function Pointer Result: {result}\n");
        }

        /// <summary>
        /// Adds two integers and returns the result.
        /// Used as a function pointer target.
        /// </summary>
        unsafe static int Add(int a, int b) => a + b;

        /// <summary>
        /// Demonstrates the impact of the SkipLocalsInit attribute.
        /// Prevents zero-initialization of local variables for performance gains.
        /// </summary>
        [SkipLocalsInit]
        static void SkipLocalsInitExample()
        {
            int uninitializedValue=8;
            Span<int> buffer = stackalloc int[5];

            // Print uninitialized local variable (May contain garbage values)
            Console.WriteLine($"Uninitialized Value (May contain garbage data): {uninitializedValue}");

            // Print stackalloc buffer (May contain uninitialized memory)
            Console.WriteLine("Buffer contents (may contain garbage values):");
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write(buffer[i] + " ");
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Partial class example demonstrating new features for partial methods.
        /// </summary>
        partial class PartialExample
        {
            /// <summary>
            /// Computes a value based on the input and returns the result.
            /// Demonstrates partial methods with return values and out parameters.
            /// </summary>
            public partial int Compute(int a, out int b);
        }

        /// <summary>
        /// Partial method implementation.
        /// </summary>
        partial class PartialExample
        {
            public partial int Compute(int a, out int b)
            {
                b = a * 2;
                return b + 10;
            }
        }

        /// <summary>
        /// Demonstrates the new capabilities of partial methods.
        /// </summary>
        static void PartialMethodExample()
        {
            PartialExample example = new();
            int result = example.Compute(5, out int output);
            Console.WriteLine($"Partial Method Result: {result}, Output: {output}\n");
        }
    }

    /// <summary>
    /// Module initializer must be in a **top-level** static class.
    /// It runs **before any static constructor or Main() method.**
    /// </summary>
    public static class ModuleInitializerDemo
    {
        [ModuleInitializer]
        public static void Initialize()
        {
            Console.WriteLine("Module Initialized!\n");
        }
    }
}
