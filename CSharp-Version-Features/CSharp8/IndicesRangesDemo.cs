using System;

namespace CSharp8
{
    /// <summary>
    /// Demonstrates the usage of Indices (^) and Ranges (..) introduced in C# 8.0.
    /// </summary>
    public static class IndicesRangesDemo
    {
        /// <summary>
        /// Executes the demonstration of indices and ranges in arrays and strings.
        /// </summary>
        public static void Run()
        {
            int[] numbers = { 10, 20, 30, 40, 50, 60 };

            // 📌 Using Indices (`^`)
            Console.WriteLine("🔹 Using Indices:");
            Console.WriteLine($"Last element: {numbers[^1]}"); // Retrieves the last element (60)
            Console.WriteLine($"Second last element: {numbers[^2]}"); // Retrieves the second last element (50)

            // 📌 Using Ranges (`..`)
            Console.WriteLine("\n🔹 Using Ranges:");

            /// <summary>
            /// Extracts a subset of elements from index 1 to 3 (4 is exclusive).
            /// </summary>
            int[] middleNumbers = numbers[1..4];
            Console.WriteLine("Subset (1..4): " + string.Join(", ", middleNumbers));

            /// <summary>
            /// Extracts the first three elements from the array.
            /// </summary>
            int[] firstThree = numbers[..3];
            Console.WriteLine("First three (..3): " + string.Join(", ", firstThree));

            /// <summary>
            /// Extracts all elements from index 3 to the end.
            /// </summary>
            int[] lastThree = numbers[3..];
            Console.WriteLine("Last three (3..): " + string.Join(", ", lastThree));

            // 📌 Using Ranges with Strings
            Console.WriteLine("\n🔹 Using Ranges with Strings:");
            string text = "Hello, World!";
            Console.WriteLine($"Original text: {text}");

            /// <summary>
            /// Extracts a substring from index 7 to the second last character.
            /// </summary>
            Console.WriteLine($"Substring (7..^1): {text[7..^1]}"); // Outputs "World"

            // 📌 Using Range Operator to Copy Entire Array
            Console.WriteLine("\n🔹 Copying Entire Array with '..':");

            /// <summary>
            /// Copies the entire array using the range operator.
            /// </summary>
            int[] copyArray = numbers[..];
            Console.WriteLine("Copied Array: " + string.Join(", ", copyArray));
        }
    }
}
