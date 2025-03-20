namespace CSharp11;


// Summary:
// In this demonstration, we explored how to use C# 11.0's list patterns for pattern matching.
// - Exact sequence matching: Matches a predefined sequence of elements in an array.
// - Variable-length patterns: Allows matching with a flexible middle section, e.g., starting with 5 and ending with 2.
// - Discards (_): Ignores specific elements in the array during matching.
// - Nested list patterns: Used for matching structures like jagged arrays or nested lists.
// These features enhance readability, conciseness, and maintainability compared to older approaches, where manual checking of array lengths and elements was required.
public static class ListPatternDemo
{
    public static void Run()
    {
        // 1. Example: Exact Sequence Match
        int[] orderQuantities = { 5, 3, 2 };
        if (orderQuantities is [5, 3, 2])  // Exact match for quantities [5, 3, 2]
        {
            Console.WriteLine("Exact order quantities matched!");  // Output: "Exact order quantities matched!"
        }

        // 2. Example: Manual Checking (Before C# 11.0)
        int[] oldOrderQuantities = { 5, 3, 2 };
        if (oldOrderQuantities.Length == 3 && oldOrderQuantities[0] == 5 && oldOrderQuantities[1] == 3 && oldOrderQuantities[2] == 2)
        {
            Console.WriteLine("Manual check: Exact order quantities matched!");  // Output: "Manual check: Exact order quantities matched!"
        }

        // 3. Example: Variable-Length Pattern (Order with any number of items)
        int[] flexibleOrderQuantities = { 5, 7, 10, 3, 2 };
        if (flexibleOrderQuantities is [5, .., 2])  // Starts with 5 and ends with 2, the middle can vary
        {
            Console.WriteLine("Order starts with 5 and ends with 2!");  // Output: "Order starts with 5 and ends with 2!"
        }

        // 4. Example: Matching with Discards (_)
        int[] discardExampleOrder = { 5, 7, 10 };
        if (discardExampleOrder is [5, _, 10])  // The first is 5, last is 10, and the middle can be anything
        {
            Console.WriteLine("Order starts with 5 and ends with 10!");  // Output: "Order starts with 5 and ends with 10!"
        }

        // 5. Example: Nested List Patterns (For Nested Orders)
        int[][] nestedOrderDetails = { new int[] { 2, 1 }, new int[] { 4, 5 } };  // Nested arrays for order details
        if (nestedOrderDetails is [[2, 1], [4, 5]])  // Matches the structure [[2, 1], [4, 5]]
        {
            Console.WriteLine("Matched nested order structure!");  // Output: "Matched nested order structure!"
        }

        // Real-world application: Let's say we have a list of customer orders, each with item quantities
        var orders = new List<int[]>()
        {
            new int[] { 5, 3, 2 },
            new int[] { 1, 4, 2 },
            new int[] { 3, 5, 7, 8, 9 }
        };

        foreach (var order in orders)
        {
            if (order is [5, .., 2])  // Checking if order starts with 5 and ends with 2
            {
                Console.WriteLine("Order starts with 5 and ends with 2!");
            }
        }
    }
}
