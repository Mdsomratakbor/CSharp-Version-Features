namespace CSharp10;

/// <summary>
/// Demonstrates the use of the sealed modifier when overriding ToString in a record type.
/// </summary>
public static class SealedToStringRecordDemo
{
    /// <summary>
    /// Represents a person with a Name and Age.
    /// The ToString method is sealed to prevent further overrides in derived records.
    /// </summary>
    public record Person(string Name, int Age)
    {
        /// <summary>
        /// Returns a formatted string containing the person's name and age.
        /// This method is sealed to prevent overriding in derived records.
        /// </summary>
        /// <returns>A string representation of the Person record.</returns>
        public sealed override string ToString() => $"{Name}, Age: {Age}";
    }

    /// <summary>
    /// Represents an employee with additional details.
    /// Inherits from Person but cannot override the ToString method.
    /// </summary>
    public record Employee(string Name, int Age, string Position) : Person(Name, Age)
    {
        // The following code would cause a compile-time error because ToString is sealed in the base record:
        // public override string ToString() => $"{Name}, Age: {Age}, Position: {Position}";
    }
}
