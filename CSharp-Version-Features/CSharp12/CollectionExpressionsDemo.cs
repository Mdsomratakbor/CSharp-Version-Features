namespace CSharp12
{
    // This class demonstrates the use of C# 12's collection expressions feature.
    // Collection expressions allow you to create and initialize collections like lists, sets, and dictionaries
    // in a more concise and readable manner, without needing the 'new' keyword or explicitly specifying the collection type.
    // The feature simplifies code by automatically inferring the type and removing boilerplate.
    public class CollectionExpressionsDemo
    {
        public static void Run()
        {
            // Example 1: List initialization with collection expressions
            // In C# 12, you can initialize a list without explicitly using 'new List<T>()' and without curly braces.
            var numbers = [1, 2, 3, 4, 5];  // Creating and initializing a list using collection expressions
            Console.WriteLine("List of numbers: " + string.Join(", ", numbers));

            // Before C# 12: You had to write it as:
            // var numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Example 2: Set initialization (automatically removes duplicates)
            // A set is a collection that automatically removes duplicates. 
            var uniqueNumbers = [1, 2, 3, 4, 4, 5];  // Duplicates are automatically removed
            Console.WriteLine("Unique numbers: " + string.Join(", ", uniqueNumbers));

            // Before C# 12: You had to use HashSet
            // var uniqueNumbers = new HashSet<int> { 1, 2, 3, 4, 4, 5 };

            // Example 3: Dictionary initialization with collection expressions
            // Collection expressions also work for initializing dictionaries with key-value pairs.
            var studentGrades = ["Alice": 90, "Bob": 85, "Charlie": 88];  // Creating a dictionary with key-value pairs
            Console.WriteLine("Student Grades:");
            foreach (var student in studentGrades)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }

            // Before C# 12: You had to use Dictionary with the 'new' keyword
            // var studentGrades = new Dictionary<string, int>
            // {
            //     { "Alice", 90 },
            //     { "Bob", 85 },
            //     { "Charlie", 88 }
            // };

            // Example 4: Empty collection initialization
            // Collection expressions also make it easier to initialize empty collections.
            var emptyList = [];  // A simple way to initialize an empty list
            Console.WriteLine("Empty list: " + (emptyList.Any() ? "Not empty" : "Empty"));

            // Before C# 12: You had to explicitly create an empty list
            // var emptyList = new List<int>();

            // Example 5: Combining collection expressions with LINQ queries
            // You can use LINQ queries to filter or transform collections.
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();  // Filter to get even numbers
            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));

            // Before C# 12: You would write LINQ queries just like above, but you would have to create the list first
            // var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        }
    }
}
