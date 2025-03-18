namespace CSharp10;

    /// <summary>
    /// Demonstrates the usage of Record Structs in C# 10.
    /// Record structs provide value-based equality while allowing immutability.
    /// </summary>
    public static class RecordsStructsDemo
    {
        public static void Run()
        {
            // Creating instances of the record struct
            PersonRecordStruct person1 = new("Alice", 25);
            PersonRecordStruct person2 = new("Alice", 25);
            PersonRecordStruct person3 = new("Bob", 30);

            // Value-based equality comparison
            Console.WriteLine($"person1 == person2: {person1 == person2}"); // True
            Console.WriteLine($"person1 == person3: {person1 == person3}"); // False

            // Using 'with' expression to create a modified copy
            var updatedPerson = person1 with { Age = 26 };
            Console.WriteLine($"Updated Person: {updatedPerson}");

            // Demonstrating a mutable record struct
            MutableRecordStruct mutablePerson = new("Charlie", 28);
            Console.WriteLine($"Before Modification: {mutablePerson}");
            mutablePerson.Age = 29; // Allowed in mutable record structs
            Console.WriteLine($"After Modification: {mutablePerson}");
        }
    }

    /// <summary>
    /// Defines an immutable record struct.
    /// Record structs provide value-based equality and work similarly to structs but with record semantics.
    /// </summary>
    public record struct PersonRecordStruct(string Name, int Age);

    /// <summary>
    /// Defines a mutable record struct by explicitly allowing property modifications.
    /// This breaks immutability but allows struct-like behavior.
    /// </summary>
    public record struct MutableRecordStruct
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public MutableRecordStruct(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

