namespace CSharp11;

/// <summary>
/// Demonstrates the use of UTF-8 string literals introduced in C# 11.
/// UTF-8 string literals (using the 'u8' suffix) allow efficient 
/// handling of UTF-8 encoded text as a ReadOnlySpan<byte> without extra allocations.
/// </summary>
public static class UTF8StringLiteralsDemo
{
    /// <summary>
    /// Executes the UTF-8 string literals demo.
    /// This method showcases how to use UTF-8 literals, convert them back to a string, 
    /// and compare them with traditional Encoding.UTF8.GetBytes().
    /// </summary>
    public static void Run()
    {
        // ✅ Using UTF-8 string literals (u8 suffix)
        ReadOnlySpan<byte> utf8Bytes = "Hello, UTF-8 World! 🌍"u8;

        // ✅ Print UTF-8 byte array
        Console.WriteLine("UTF-8 Bytes: " + BitConverter.ToString(utf8Bytes.ToArray()));

        // ✅ Convert UTF-8 bytes back to a string
        string decodedString = Encoding.UTF8.GetString(utf8Bytes);
        Console.WriteLine("Decoded String: " + decodedString);

        // ✅ Compare with Encoding.UTF8.GetBytes()
        byte[] manualBytes = Encoding.UTF8.GetBytes("Hello, UTF-8 World! 🌍");
        Console.WriteLine("Manual Encoding Bytes: " + BitConverter.ToString(manualBytes));

        // ✅ Check if both results are the same
        Console.WriteLine("Are Both Byte Arrays Equal? " + utf8Bytes.SequenceEqual(manualBytes));
    }
}
