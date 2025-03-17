using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    public static class AsyncStreamDemo
    { 
        public static async IAsyncEnumerable<int> GenerateNumbersAsync(int count, int delayMs)
        {
            for (int i = 1; i <= count; i++)
            {
                await Task.Delay(delayMs); 
                yield return i;
            }
        }

        public static IEnumerable<int> GetNumbers()
        {
            Console.WriteLine("Fetching number 1...");
            yield return 1;  // The method pauses here and returns 1

            Console.WriteLine("Fetching number 2...");
            yield return 2;  // The method pauses again and returns 2

            Console.WriteLine("Fetching number 3...");
            yield return 3;  // The method pauses again and returns 3
        }

        public static async Task Run()
        {
            Console.WriteLine("Fetching numbers asynchronously:");
            await foreach (var number in AsyncStreamDemo.GenerateNumbersAsync(5, 200))
            {
                Console.WriteLine($"Received: {number}");
            }

            Console.WriteLine("Async stream processing completed.");

            Console.WriteLine("-------------------------\n");

            Console.WriteLine("Fetching numbers in parallel:");

            var tasks = Enumerable.Range(1, 200)
                .Select(async i =>
                {
                    await Task.Delay(500); // Simulate work
                    Console.WriteLine($"Received: {i}");
                });

            await Task.WhenAll(tasks);

            Console.WriteLine("Parallel processing completed.");


            foreach (var number in GetNumbers())
            {
                Console.WriteLine($"Received: {number}");
            }

        }
    }
}
