namespace CSharp11;

/// <summary>
/// Demonstrates the usage of raw string literals introduced in C# 11.
/// This includes examples for JSON, SQL queries, and multi-line text handling.
/// </summary>
public static class RawStringLiteralsDemo
{
    /// <summary>
    /// Executes and prints various examples of raw string literals in C# 11.
    /// </summary>
    public static void Run()
    {
        // Example 1: JSON using raw string literals
        string json = """
        {
            "name": "Alice",
            "age": 28,
            "city": "Seattle"
        }
        """;

        Console.WriteLine("JSON Example:");
        Console.WriteLine(json);
        Console.WriteLine();

        // Example 2: SQL Query using raw string literals
        string sqlQuery = """
        SELECT * FROM Users
        WHERE Age > 25
        ORDER BY Name ASC;
        """;

        Console.WriteLine("SQL Query Example:");
        Console.WriteLine(sqlQuery);
        Console.WriteLine();

        // Example 3: Multi-line text
        string multilineText = """
        This is a multi-line string
        written using C# 11 raw string literals.
        It preserves the formatting exactly as written.
        """;

        Console.WriteLine("Multi-line Text Example:");
        Console.WriteLine(multilineText);
    }
}
