using System;

#nullable enable // Enable nullable reference types

namespace CSharp8
{
    /// <summary>
    /// Demonstrates nullable reference types introduced in C# 8.0.
    /// </summary>
    public static class NullableReferenceDemo
    {
        public static void Run()
        {
            User? user = GetUser(); // Might return null
            PrintUserInfo(user);
        }

        /// <summary>
        /// Simulates retrieving a user, which might return null.
        /// </summary>
        /// <returns>A nullable User object.</returns>
        private static User? GetUser()
        {
            Console.Write("Enter your name (leave blank for null): ");
            string? name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
                return null;

            return new User(name);
        }

        /// <summary>
        /// Prints user information while handling possible null values.
        /// </summary>
        /// <param name="user">A nullable User object.</param>
        private static void PrintUserInfo(User? user)
        {
            if (user is null)
            {
                Console.WriteLine("No user information provided.");
            }
            else
            {
                Console.WriteLine($"User Name: {user.Name}");
            }
        }
    }

    /// <summary>
    /// Represents a User with a nullable Name property.
    /// </summary>
    public class User
    {
        public string Name { get; }

        public User(string name)
        {
            Name = name;
        }
    }
}
