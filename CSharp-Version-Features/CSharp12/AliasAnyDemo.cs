    // 1. Alias for a tuple (x, y) as point2D
    using point2D = (int x, int y);

    // 2. Alias for List<int>
    using intList = System.Collections.Generic.List<int>;

    // 3. Alias for Dictionary<string, int>
    using stringDict = System.Collections.Generic.Dictionary<string, int>;
    namespace CSharp12;

    // This demo showcases the usage of type aliases in C# 12. 
    // Type aliases allow us to define alternative names for existing types, 
    // making the code cleaner and more readable. 
    // Examples of aliasing include:
    // - Alias for a tuple (point2D)
    // - Alias for List<int> (intList)
    // - Alias for Dictionary<string, int> (stringDict)
    public static class AliasAnyDemo
    {
        // Run method demonstrating the usage of different type aliases
        public static void Run()
        {
            // 1. Tuple alias (point2D)
            point2D point = (x: 10, y: 20);
            Console.WriteLine($"Point: ({point.x}, {point.y})");  // Output: Point: (10, 20)

            // 2. Alias for List<int> (intList)
            intList numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("List of numbers:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);  // Output: 1, 2, 3, 4, 5
            }

            // 3. Alias for Dictionary<string, int> (stringDict)
            stringDict scores = new Dictionary<string, int>
            {
                { "Alice", 90 },
                { "Bob", 85 },
                { "Charlie", 88 }
            };
            Console.WriteLine("Scores:");
            foreach (var entry in scores)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");  // Output: Alice: 90, Bob: 85, Charlie: 88
            }
        }
    }



