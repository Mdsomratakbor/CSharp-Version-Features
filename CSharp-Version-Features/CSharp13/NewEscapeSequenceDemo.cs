namespace CSharp13
{
    /// <summary>
    /// Demonstrates the new escape sequence \e for the ESCAPE character (U+001B) in C# 13.
    /// 
    /// Previously, escape sequences like \u001b (Unicode) or \x1b (Hexadecimal) were used to represent 
    /// the ESCAPE character. However, using \x1b could cause issues if the next characters after 1b
    /// were valid hexadecimal digits, potentially forming an unintended escape sequence.
    ///
    /// With C# 13, you can now use \e as a more readable and concise way to represent the ESCAPE character
    /// while avoiding ambiguity. The new escape sequence is more consistent with shell scripting conventions
    /// and ensures better readability and maintainability in C# code.
    /// </summary>
    public static class NewEscapeSequenceDemo
    {
        public static void Run()
        {
             // Using \u001b (Unicode escape sequence) for ESC (U+001B)
            Console.WriteLine("\u001b[31mThis text is red using \\u001b\e[0m");

            // Using \x1b (Hexadecimal escape sequence) for ESC (U+001B)
            Console.WriteLine("\x1b[32mThis text is green using \\x1b\e[0m");

            
            // Using the new escape sequence \e for ESC (U+001B)
            Console.WriteLine("\e[31mThis text is red\e[0m");

            // Another example: green text
            Console.WriteLine("\e[32mThis text is green\e[0m");

            // Resetting to default color
            Console.WriteLine("This text is the default color");
        }
    }
}
