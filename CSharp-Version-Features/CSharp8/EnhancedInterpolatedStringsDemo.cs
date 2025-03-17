using System;

namespace CSharp8
{
    public static class EnhancedInterpolatedStringsDemo
    {
        public static void Run()
        {
            string name = "Samrat";
            string path = "C:\\Users\\Samrat\\Documents";

            // ✅ Old way (still valid)
            string message1 = $@"Hello, {name}! Your files are located at: {path}";

            // ✅ New way (now valid in C# 8)
            string message2 = @$"Hello, {name}! Your files are located at: {path}";

            Console.WriteLine(message1);
            Console.WriteLine(message2);
        }
    }
}
