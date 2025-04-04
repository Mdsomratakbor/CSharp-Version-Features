using System;

namespace CSharp13
{
    /// <summary>
    /// Demonstrates Implicit Index Access in C# 13.
    /// This feature allows using indexers with the ^ (caret) operator directly in object initializers,
    /// enabling cleaner and more concise initialization of arrays, spans, lists, etc.
    /// </summary>
    public static class ImplicitIndexAccessDemo
    {
        public static void Run()
        {
            Console.WriteLine("=== Before C# 13 ===");

            // ✅ Before C# 13: Index from the end manually after initialization
            var timerOld = new TimerRemaining();

            // Assign values from the end of the array using the ^ (caret) operator
            timerOld.Buffer[^1] = 0;  // Last element
            timerOld.Buffer[^2] = 1;
            timerOld.Buffer[^3] = 2;
            timerOld.Buffer[^4] = 3;
            timerOld.Buffer[^5] = 4;
            timerOld.Buffer[^6] = 5;
            timerOld.Buffer[^7] = 6;
            timerOld.Buffer[^8] = 7;
            timerOld.Buffer[^9] = 8;
            timerOld.Buffer[^10] = 9; // First element

            Console.WriteLine("Timer Buffer (Manual Initialization):");
            Console.WriteLine(string.Join(", ", timerOld.Buffer));


            Console.WriteLine("\n=== After C# 13 ===");

            // ✅ In C# 13: Use implicit index access directly inside the object initializer
            var timerNew = new TimerRemaining
            {
                Buffer =
                {
                    [^1] = 0,   // Last element
                    [^2] = 1,
                    [^3] = 2,
                    [^4] = 3,
                    [^5] = 4,
                    [^6] = 5,
                    [^7] = 6,
                    [^8] = 7,
                    [^9] = 8,
                    [^10] = 9  // First element
                }
            };

            Console.WriteLine("Timer Buffer (Object Initializer with Implicit Index):");
            Console.WriteLine(string.Join(", ", timerNew.Buffer));
        }
    }

    /// <summary>
    /// Represents a timer-like structure holding a buffer of 10 integers.
    /// </summary>
    public class TimerRemaining
    {
        public int[] Buffer { get; set; } = new int[10];
    }
}
