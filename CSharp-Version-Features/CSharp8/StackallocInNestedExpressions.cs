using System;
using System.Linq;

namespace CSharp8
{
    public static class StackallocInNestedExpressions
    {
        public static void Run()
        {
            // Using stackalloc in a nested expression to allocate an array and perform an operation
            Span<int> stackArray = stackalloc int[5] { 1, 2, 3, 4, 5 };
            var result = stackArray[0] + stackArray[1];  // Nested expression: sum of first two elements
            Console.WriteLine($"Sum of first two elements: {result}");  // Output: 3

            // Passing stack-allocated array to a method in a nested expression
            ProcessBuffer(stackalloc int[4] { 10, 20, 30, 40 });

            // Nested expression with stackalloc and arithmetic operations
            var total = (stackalloc int[2] { 5, 10 })[0] * (stackalloc int[2] { 2, 3 })[1];  // Nested stackalloc with arithmetic
            Console.WriteLine($"Total after multiplication: {total}");  // Output: 30
        }

        // Method that processes a stack-allocated buffer
        static void ProcessBuffer(Span<int> buffer)
        {
            Console.WriteLine("Processing buffer:");
            foreach (var item in buffer)
            {
                Console.WriteLine(item);
            }
        }
    }
}
