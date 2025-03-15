using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CSharp8
{
    /// <summary>
    /// Demonstrates the use of the 'using declaration' feature introduced in C# 8.0,
    /// async disposal, and processing multiple resources in a single 'using' statement.
    /// </summary>
    public class UsingDeclarationDemo
    {
        /// <summary>
        /// Loads numbers from a file using the traditional 'using' statement with an explicit block.
        /// </summary>
        /// <param name="filePath">Path to the file containing numbers.</param>
        /// <returns>A collection of integers loaded from the file.</returns>
        public IEnumerable<int> LoadNumbersWithExplicitBlock(string filePath)
        {
            var numbers = new List<int>();

            using (StreamReader reader = File.OpenText(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) is not null)
                {
                    if (int.TryParse(line, out int number))
                    {
                        numbers.Add(number);
                    }
                }
            }

            return numbers;
        }

        /// <summary>
        /// Loads numbers from a file using the 'using' declaration (C# 8.0 feature).
        /// </summary>
        /// <param name="filePath">Path to the file containing numbers.</param>
        /// <returns>A collection of integers loaded from the file.</returns>
        public IEnumerable<int> LoadNumbersWithUsingDeclaration(string filePath)
        {
            using StreamReader reader = File.OpenText(filePath);

            var numbers = new List<int>();
            string line;
            while ((line = reader.ReadLine()) is not null)
            {
                if (int.TryParse(line, out int number))
                {
                    numbers.Add(number);
                }
            }
            return numbers;
        }

        /// <summary>
        /// Processes two files (numbers and words) and prints their contents to the console.
        /// Uses multiple resources in a single 'using' statement.
        /// Advantages:
        /// ✅ Simplifies code by combining multiple resource declarations in a single 'using' statement.
        /// ✅ Automatically handles the disposal of both resources when the 'using' block ends.
        /// ✅ Reduces indentation, leading to cleaner code.

        /// Disadvantages:
        /// ⚠️ Resource disposal happens in reverse order of declaration. This could lead to unexpected behaviors if one resource depends on the other.
        /// ⚠️ Limited flexibility. If any specific logic needs to be performed when disposing resources (e.g., error handling during disposal), a separate 'using' block might be preferred.
        /// ⚠️ If the resources are complex or if there is a risk of exceptions, splitting the 'using' blocks could improve exception handling and debugging.
        /// </summary>
        public void ProcessMultipleFilesInSingleUsingStatement()
        {
            string numbersFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "numbers.txt");
            string wordsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "words.txt");

            using (StreamReader numbersFile = File.OpenText(Path.Combine(numbersFilePath)),
                               wordsFile = File.OpenText(wordsFilePath))
            {
                string line;
                while ((line = numbersFile.ReadLine()) is not null)
                {
                    Console.WriteLine($"Number: {line}");
                }

                while ((line = wordsFile.ReadLine()) is not null)
                {
                    Console.WriteLine($"Word: {line}");
                }
            }
        }

        /// <summary>
        /// Demonstrates calling all the features in one method: loading numbers, processing files, and async file loading.
        /// </summary>
        public static async Task Run()
        {
            var demo = new UsingDeclarationDemo();

            Console.WriteLine("====Loading numbers using traditional using statement:====");
            string numbersFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "numbers.txt");
            var numbers = demo.LoadNumbersWithExplicitBlock(numbersFilePath);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\n====Loading numbers using using declaration:====");
            var numbersWithoutCurly = demo.LoadNumbersWithUsingDeclaration(numbersFilePath);
            foreach (var number in numbersWithoutCurly)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\n====Processing files:====");
            demo.ProcessMultipleFilesInSingleUsingStatement();

            Console.WriteLine("\n====Loading file asynchronously:====");
            await LoadFileAsync(numbersFilePath);
        }

        /// <summary>
        /// Loads a file asynchronously and demonstrates async resource disposal with 'await using'.
        /// Advantages:
        /// ✅ Ensures that the resource (reader) is disposed asynchronously when done, preventing potential memory leaks.
        /// ✅ Uses the 'await using' statement, which simplifies handling of asynchronous disposable resources.
        /// ✅ The method allows for better performance when dealing with I/O-bound operations such as reading files asynchronously.

        /// Disadvantages:
        /// ⚠️ Only supported in C# 8.0 and above, so it may not be available in earlier versions of C#.
        /// ⚠️ It may be more challenging to understand and use for developers not familiar with async disposal patterns.
        /// ⚠️ If the `ReadAsync` method encounters errors or exceptions, error handling might become more complex, and developers may need to explicitly handle exceptions within the `await using` block.
        /// </summary>
        /// <param name="filePath">The path to the file to be loaded asynchronously.</param>
        public static async Task LoadFileAsync(string filePath)
        {
            await using (var reader = new AsyncDisposableExample())
            {
                await reader.ReadAsync(filePath);
            }
        }
    }

    /// <summary>
    /// Example class implementing IAsyncDisposable for asynchronous disposal logic.
    /// Handles file reading asynchronously and ensures proper cleanup of resources.
    /// </summary>
    public class AsyncDisposableExample : IAsyncDisposable
    {
        private bool _disposed = false;
        private StreamReader _reader;

        /// <summary>
        /// Asynchronously reads the contents of the specified file and writes each line to the console.
        /// </summary>
        /// <param name="filePath">The path to the file to be read.</param>
        /// <exception cref="ObjectDisposedException">Thrown if the instance has already been disposed.</exception>
        /// <exception cref="FileNotFoundException">Thrown if the specified file is not found.</exception>
        /// <exception cref="IOException">Thrown if an I/O error occurs during file reading.</exception>
        public async Task ReadAsync(string filePath)
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(AsyncDisposableExample));

            try
            {
                _reader = new StreamReader(filePath);

                string line;
                while ((line = await _reader.ReadLineAsync()) != null)
                {
                    Console.WriteLine($"Reading from {filePath}: {line}");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error: File not found at {filePath}. Exception: {ex.Message}");
                throw;
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error: IO exception occurred while reading the file. Exception: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Asynchronously disposes of the resources used by the AsyncDisposableExample class.
        /// </summary>
        public async ValueTask DisposeAsync()
        {
            if (_disposed)
                return;

            if (_reader != null)
            {
                 _reader.Dispose();
                Console.WriteLine("Async resource (StreamReader) disposed.");
            }

            _disposed = true;
        }

    
    }

}
