namespace CSharp11
{
    /// <summary>
    /// Demonstrates pattern matching on Span<char> and ReadOnlySpan<char> in C# 11.
    /// C# 11 introduces enhanced pattern matching capabilities with `Span<char>` and `ReadOnlySpan<char>`.
    /// This feature allows for efficient handling of string slices and substrings without allocating new strings,
    /// offering significant performance improvements in scenarios that involve intensive string operations.
    /// The demo showcases:
    /// - Matching on a full string using patterns.
    /// - Slicing the span for substring matching.
    /// - Utilizing switch expressions with `Span<char>` and `ReadOnlySpan<char>`.
    /// - Combining patterns with logical OR.
    /// </summary>
    public static class SpanPatternMatchDemo
    {
        // This method demonstrates pattern matching with Span<char> and ReadOnlySpan<char>.
        public static void Run()
        {
            // Example 1: Basic pattern matching on the whole string
            string input = "Hello World!";
            ReadOnlySpan<char> span = input.AsSpan();

            // Check if the entire span matches a specific constant string ("Hello")
            if (span is "Hello")  // Matches the start of the string
            {
                Console.WriteLine("The string starts with 'Hello'");
            }
            else
            {
                Console.WriteLine("The string does not start with 'Hello'");
            }

            // Example 2: Pattern matching a substring using slicing
            // Match a substring "World" starting from index 7 to the end
            if (span[7..] is "World")  // Matches 'World' starting from index 7
            {
                Console.WriteLine("The string contains 'World' starting from index 7");
            }
            else
            {
                Console.WriteLine("The string does not contain 'World' starting from index 7");
            }

            // Example 3: Pattern matching with a more complex case using Switch
            string anotherInput = "CSharp 11 is great!";
            ReadOnlySpan<char> anotherSpan = anotherInput.AsSpan();

            // Use a switch statement with pattern matching
            switch (anotherSpan)
            {
                // Case 1: If it starts with "CSharp"
                case var _ when anotherSpan.StartsWith("CSharp"):
                    Console.WriteLine("The string starts with 'CSharp'");
                    break;

                // Case 2: If it ends with "great!"
                case var _ when anotherSpan.EndsWith("great!"):
                    Console.WriteLine("The string ends with 'great!'");
                    break;

                // Default case: If it matches neither
                default:
                    Console.WriteLine("The string doesn't match the specified patterns.");
                    break;
            }

            // Example 4: Checking multiple patterns using logical OR
            if (span is "Hello" or "Hi")  // Matches either "Hello" or "Hi"
            {
                Console.WriteLine("The string starts with 'Hello' or 'Hi'");
            }
            else
            {
                Console.WriteLine("The string does not start with 'Hello' or 'Hi'");
            }
        }
    }
}
