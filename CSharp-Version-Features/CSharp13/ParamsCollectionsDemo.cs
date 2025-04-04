using System;
using System.Collections.Generic;

namespace CSharp13
{
    /// <summary>
    /// This class demonstrates the usage of the 'params' keyword in C#.
    /// The 'params' keyword allows methods to accept a variable number of arguments of a specified type.
    /// With C# 13, 'params' is not limited to arrays, and now supports collections such as List<T>,
    /// Span<T>, and interfaces like IEnumerable<T>, making it more flexible in handling variable-length arguments.
    /// </summary>
    public class ParamsCollectionsDemo
    {
        /// <summary>
        /// Prints all the numbers passed as arguments.
        /// This method demonstrates how 'params' can be used to handle a series of integers passed as arguments.
        /// </summary>
        /// <param name="numbers">A variable number of integer arguments.</param>
        public static void PrintNumbers(params int[] numbers)
        {
            Console.WriteLine("Numbers:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Prints all the numbers in a List.
        /// This method demonstrates how 'params' can now accept a List as a parameter.
        /// </summary>
        /// <param name="numbers">A List of integers.</param>
        public static void PrintListOfNumbers(params List<int> numbers)
        {
            Console.WriteLine("Numbers from List:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates how 'params' works with Span<T>.
        /// </summary>
        /// <param name="numbers">A Span of integers.</param>
        public static void PrintSpanOfNumbers(params Span<int> numbers)
        {
            Console.WriteLine("Numbers from Span:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Accepts a variable number of string arguments and joins them into a single string.
        /// This method demonstrates how multiple strings passed as arguments can be concatenated into a single string.
        /// </summary>
        /// <param name="words">A variable number of string arguments.</param>
        public static void JoinStrings(params string[] words)
        {
            string result = string.Join(" ", words);
            Console.WriteLine("Joined String: " + result);
        }

        /// <summary>
        /// Demonstrates how params can be used with IEnumerable<T> (an interface type).
        /// </summary>
        /// <param name="numbers">A variable number of IEnumerable<int> items.</param>
        public static void PrintNumbersFromIEnumerable(params IEnumerable<int>[] numbers)
        {
            Console.WriteLine("Numbers from IEnumerable:");
            foreach (var enumerable in numbers)
            {
                foreach (var number in enumerable)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates how params can be used with different types of collections like List<T>, Span<T>, and IEnumerable<T>.
        /// </summary>
        public static void Run()
        {
            // Using params with a List
            Console.WriteLine("Printing numbers from a List using params:");
            PrintListOfNumbers(10, 20, 30, 40, 50);

            // Using params with Span<T>
            Console.WriteLine("Printing numbers from a Span using params:");
            PrintSpanOfNumbers(100, 200, 300, 400);

            // Using params with IEnumerable<T>
            PrintNumbersFromIEnumerable([1, 2, 3, 4, 5], new List<int> { 6, 7, 8, 9, 10 });

            // Demonstrating PrintNumbers with a series of integers
            Console.WriteLine("Printing numbers using params:");
            PrintNumbers(1, 2, 3, 4, 5);

            // Demonstrating JoinStrings with multiple string arguments
            Console.WriteLine("Joining strings using params:");
            JoinStrings("Hello", "World", "This", "is", "C#");
        }
    }
}
