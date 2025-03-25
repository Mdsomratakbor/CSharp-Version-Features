namespace CSharp12;

    // This class demonstrates the use of C# 12's collection expressions feature.
    // Collection expressions allow you to create and initialize collections like lists, sets, and dictionaries
    // in a more concise and readable manner, without needing the 'new' keyword or explicitly specifying the collection type.
    // The feature simplifies code by automatically inferring the type and removing boilerplate.
    public class CollectionExpressionsDemo
    {
        public static void Run()
        {
            // Example 1: List initialization with collection expressions
            // In C# 12, you can initialize an array directly using collection expressions, 
            // eliminating the need for 'new int[] { }' or explicitly specifying the type.
            int[] numbers = [1, 2, 3, 4, 5];
            Console.WriteLine("List of numbers: " + string.Join(", ", numbers));

            // Explanation: 
            // The expression [1, 2, 3, 4, 5] initializes an array of integers, and the type is inferred as 'int[]'.
            // No need to explicitly declare the type or use 'new int[]'.

            // Example 2: Using collection expressions with Span<T>
            Span<int> ints = [1, 2, 3, 4, 5, 7];
            Console.WriteLine("Span of numbers: " + string.Join(", ", ints.ToArray()));

            // Explanation: 
            // The 'Span<int>' type allows efficient, memory-safe manipulation of contiguous data.
            // We use collection expressions to initialize the Span with the values directly.

            // Example 3: Creating a jagged array using collection expressions
            int[][] atp = [[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13, 14, 15, 16]];
            Console.WriteLine("ATP (Jagged Array):");
            foreach (var row in atp)
            {
                Console.WriteLine(string.Join(", ", row));
            }

            // Explanation:
            // A jagged array (array of arrays) is initialized using collection expressions.
            // Each row (sub-array) is created in a concise manner, and the overall jagged array 'atp' is created without needing explicit array creation syntax.

            // Example 4: Using the spread operator to combine arrays
            int[] row0 = [1, 2, 3, 4];
            int[] row1 = [5, 6, 7, 8];
            int[] row2 = [9, 10, 11, 12];
            int[] row3 = [13, 14, 15, 16];
            int[] createATP = [.. row0, .. row1, .. row2, .. row3];

            // Explanation:
            // The spread operator '...' is used to merge the individual arrays 'row0', 'row1', 'row2', and 'row3' into a single array.
            // This eliminates the need to manually copy elements from each row into the new array.

            // Example 5: Removing duplicates using collection expressions (sets)
            int[] uniqueNumbers = [1, 2, 3, 4, 4, 5];  // Duplicates are automatically removed
            Console.WriteLine("Unique numbers: " + string.Join(", ", uniqueNumbers));

            // Explanation:
            // The collection expression [1, 2, 3, 4, 4, 5] automatically removes duplicates. 
            // This works because C# 12 supports collection initialization with unique constraints (such as for sets or lists).

            // Example 6: Initializing an empty collection
            int[] emptyList = [];  // A simple way to initialize an empty list
            Console.WriteLine("Empty list: " + (emptyList.Any() ? "Not empty" : "Empty"));

            // Explanation:
            // The expression '[]' creates an empty array.
            // It makes it clear and easy to create an empty collection without needing to specify a length or type explicitly.

            // Example 7: Using LINQ to filter a collection (even numbers)
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

            // Explanation:
            // In this example, LINQ is used to filter the original list of numbers to only include even numbers.
            // The 'Where' method is a standard LINQ function that filters based on the condition provided (n % 2 == 0).

            int factor = 10;

            int[] transformed = [.. numbers.Select(n => n * factor)];



            Console.WriteLine(string.Join(", ", transformed));


            // Example merge List
            List<int> list1 = [1, 2, 3];

            List<int> list2 = [4, 5, 6];

            List<int> mergedList = [.. list1, .. list2];



            Console.WriteLine(string.Join(", ", mergedList));  // Output: 1, 2, 3, 4, 5, 6   
        }
    }
