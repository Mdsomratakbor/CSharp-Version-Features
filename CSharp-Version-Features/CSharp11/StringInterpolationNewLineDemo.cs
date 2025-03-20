namespace CSharp11;

/// <summary>
/// Demonstrates C# 11 features, specifically multi-line string interpolation,
/// including conditionals and localization in different languages.
/// It compares the new approach with the old approach of string concatenation and
/// showcases the formatted output in both English and Russian.
/// </summary>
public static class StringInterpolationNewLineDemo
{
    public static void Run()
    {
        var name = "Alice";
        var age = 25;
        var scores = new[] { 85, 90, 78, 92, 88 }; // Example scores
        var averageScore = scores.Average();

        // ✅ New Approach (Multi-line string interpolation)
        var message = $"""
        Hello, {name}!
        You are {age} years old.
        Your average test score is {averageScore:F2}.
        Status: {(averageScore >= 80 ? "Passed" : "Failed")}
        """;

        Console.WriteLine("🚀 New C# 11 Approach:");
        Console.WriteLine(message);

        // ✅ Old Approach (Before C# 11)
        var messageOld = "Hello, " + name + "!\n" +
                         "You are " + age + " years old.\n" +
                         "Your average test score is " + averageScore.ToString("F2") + ".\n" +
                         "Status: " + (averageScore >= 80 ? "Passed" : "Failed");

        Console.WriteLine("\n🛑 Old Approach:");
        Console.WriteLine(messageOld);


    }
}


