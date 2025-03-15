using System;

namespace CSharp8
{
    /// <summary>
    /// Demonstrates C# 8.0 Pattern Matching Enhancements.
    /// Includes switch expressions, tuple pattern matching,
    /// property pattern matching, and positional pattern matching.
    /// </summary>
    public class PatternMatchingDemo
    {
        public static void Run()
        {
            Console.WriteLine("=== Switch Expression Example ===");
            Console.WriteLine(GetCategory(25)); // Expected output: Adult

            Console.WriteLine("\n=== Tuple Pattern Matching ===");
            Console.WriteLine(GetWeatherStatus(true, false)); // Expected output: Warm but Rainy

            Console.WriteLine("\n=== Property Pattern Matching ===");
            Person john = new Person("John", 25);
            Console.WriteLine(CheckPerson(john)); // Expected output: Adult John

            Console.WriteLine("\n=== Positional Pattern Matching ===");
            Coordinate p = new Coordinate(-5, 3);
            Console.WriteLine(GetQuadrant(p)); // Expected output: Quadrant 2
        }

        /// <summary>
        /// Determines the category of a person based on age.
        /// </summary>
        /// <param name="age">Age of the person</param>
        /// <returns>Category of the person</returns>
        public static string GetCategory(int age)
        {
            return age switch
            {
                < 18 => "Minor",
                >= 18 and < 65 => "Adult",
                >= 65 => "Senior"
            };
        }

        /// <summary>
        /// Determines the weather status based on rain and temperature.
        /// </summary>
        /// <param name="isRaining">Indicates if it's raining</param>
        /// <param name="isCold">Indicates if it's cold</param>
        /// <returns>Weather status</returns>
        public static string GetWeatherStatus(bool isRaining, bool isCold) =>
            (isRaining, isCold) switch
            {
                (true, true) => "Cold and Rainy",
                (true, false) => "Warm but Rainy",
                (false, true) => "Cold but Dry",
                (false, false) => "Warm and Sunny"
            };

        /// <summary>
        /// Checks if the given person is an adult named John.
        /// </summary>
        /// <param name="p">Person object</param>
        /// <returns>Status message</returns>
        public static string CheckPerson(Person p) =>
            p switch
            {
                { Age: > 18, Name: "John" } => "Adult John",
                _ => "Not Adult John"
            };

        /// <summary>
        /// Determines the quadrant of a given coordinate.
        /// </summary>
        /// <param name="point">Coordinate object</param>
        /// <returns>Quadrant number</returns>
        public static string GetQuadrant(Coordinate point) =>
            point switch
            {
                ( > 0, > 0) => "Quadrant 1",
                ( < 0, > 0) => "Quadrant 2",
                ( < 0, < 0) => "Quadrant 3",
                ( > 0, < 0) => "Quadrant 4",
                _ => "Origin"
            };
    }

    /// <summary>
    /// Represents a person with a name and age.
    /// </summary>
    public class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age) => (Name, Age) = (name, age);
    }

    /// <summary>
    /// Represents a coordinate point in a 2D plane.
    /// </summary>
    public class Coordinate
    {
        public int X { get; }
        public int Y { get; }

        public Coordinate(int x, int y) => (X, Y) = (x, y);

        /// <summary>
        /// Deconstructs the coordinate into X and Y values.
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
    }
}