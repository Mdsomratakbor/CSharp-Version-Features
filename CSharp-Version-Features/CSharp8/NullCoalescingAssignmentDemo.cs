using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    /// <summary>
    /// Demonstrates the use of the Null-Coalescing Assignment (??=) operator in C#.
    /// Includes examples with nullable types like strings, integers, lists, 
    /// and a non-nullable string.
    /// </summary>
    public static class NullCoalescingAssignmentDemo
    {
        public static void Run()
        {
            // Example 1: Nullable String
            string? name = null;
            Console.WriteLine($"Before assignment: {name}");
            name ??= "Default Name";
            Console.WriteLine($"After assignment: {name}");

            // Example 2: Nullable Integer
            int? age = null;
            Console.WriteLine($"Before assignment: {age}");
            age ??= 30;
            Console.WriteLine($"After assignment: {age}");

            // Example 3: Nullable List
            List<string>? items = null;
            Console.WriteLine($"Before assignment: {items?.Count ?? 0} items");
            items ??= new List<string>();
            items.Add("Item 1");
            items.Add("Item 2");
            Console.WriteLine($"After assignment: {items?.Count ?? 0} items");

            // Example 4: Non-nullable string
            string greeting = "Hello";
            Console.WriteLine($"Before assignment: {greeting}");
            greeting ??= "New Greeting";
            Console.WriteLine($"After assignment: {greeting}");
        }
    }
}
