namespace CSharp10;

/// <summary>
/// Demonstrates C# 10's ability to mix declaration and assignment in deconstruction.
/// </summary>
public class DeconstructionDemo
{
    /// <summary>
    /// Retrieves a tuple with user details.
    /// </summary>
    /// <returns>A tuple containing user ID and username.</returns>
    private static (int userId, string username) GetUser()
    {
        return (101, "JohnDoe");
    }

    public static void Run()
    {
        Console.WriteLine("Before deconstruction:");

        int existingUserId = 0; // Already declared variable

        // Mixing declaration and assignment in C# 10
        (existingUserId, string newUsername) = GetUser();

        Console.WriteLine($"User ID: {existingUserId}, Username: {newUsername}");
    }
}


