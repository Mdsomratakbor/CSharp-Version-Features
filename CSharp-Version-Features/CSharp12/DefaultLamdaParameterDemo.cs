using System.Security.Cryptography.X509Certificates;

namespace CSharp12;

    /// <summary>
    /// Demonstrates the use of default parameters in lambda expressions.
    /// This feature allows you to specify default values for lambda parameters,
    /// enabling more flexible and concise lambda expressions.
    /// </summary>
    public static class DefaultLamdaParameteDemo
    {
        /// <summary>
        /// The entry point for demonstrating default lambda parameter usage.
        /// </summary>
        public static void Run()
        {

            // Example of a lambda with a default parameter


            var add = (int x, int y= 5) => x+y;

            Console.WriteLine(add(10));  // Uses the default value of 5 for 'y'
            Console.WriteLine(add(10, 3));  // Overrides the default value of 'y'
        }
    }

