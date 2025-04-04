using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp13
{
    /// <summary>
    /// Demonstrates the use of `ref` in iterators and async methods in c# 13.
    /// This example simulates updating a user's profile message asynchronously and efficiently.
    /// </summary>
    public class RefInIteratorsAndAsyncMethodsDemo
    {
        // Simulating a user's profile message
        public static string myMessage = "Welcome to your profile, ";

        /// <summary>
        /// Main entry point that runs the demo asynchronously.
        /// </summary>
        public static async Task Run()
        {
            Console.WriteLine("Ref in Iterators and Async Methods - User Profile Message");

            // Displaying the initial message before any updates
            Console.WriteLine($"MyMessage before AddMessage() is called: {myMessage}");

            // Calling the async method that modifies the message
            await AddMessage();

            // Displaying the final message after it has been updated
            Console.WriteLine($"MyMessage after AddMessage() is called: {myMessage}");
        }

        /// <summary>
        /// Asynchronously adds a message to the user's profile.
        /// Simulates an async operation, like fetching data or updating information.
        /// </summary>
        public static async Task AddMessage()
        {
            // Simulating async work, like fetching data or waiting for an operation
            await Task.Delay(TimeSpan.FromMilliseconds(500));

            // Getting a reference to the original message to modify it directly
            ref var myMessage = ref GetMyMessage();

            // Adding more text to the profile message
            AddToMyMessage(ref myMessage, "Md Samrat!");

            // Simulating more async processing (e.g., saving updated message)
           // await Task.Delay(TimeSpan.FromMilliseconds(500));

            // Adding another part to the message after some time
            //AddToMyMessage(ref myMessage, " Enjoy your stay!");
        }

        /// <summary>
        /// Gets a reference to the original message so it can be modified directly.
        /// </summary>
        public static ref string GetMyMessage()
        {
            return ref myMessage;
        }

        /// <summary>
        /// Adds additional text to the user's message by modifying it through a reference.
        /// </summary>
        public static void AddToMyMessage(ref string message, string theMessage)
        {
            message += theMessage;
        }
    }
}

  // NOTE: We cannot use `ref` across an `await` boundary. 
            // A `ref` local cannot be preserved across 'await' or 'yield' boundary (CS9217).
            // To work around this, we return updated values instead of using `ref`.
            // Example: Update the message and return it.