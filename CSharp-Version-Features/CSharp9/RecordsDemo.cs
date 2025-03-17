using System;

namespace CSharp9
{
    /// <summary>
    /// Demonstrates the use of records in C# 9.0, showcasing their value-based equality, immutability,
    /// with-expressions, inheritance in both records and classes, and highlights the differences between
    /// records and traditional classes.
    /// </summary>
    public static class RecordsDemo
    {
        /// <summary>
        /// Runs a demo showing:
        /// - Creation of records and comparison using value-based equality.
        /// - Immutability of records and how with-expressions allow changes without altering the original instance.
        /// - Inheritance in records and classes and how it simplifies data modeling.
        /// - Comparison between records and classes in terms of immutability, equality, and syntax.
        /// </summary>
        public static void Run()
        {
            // Demonstrating Record creation and value-based equality
            var person1 = new Person("John", 30);
            var person2 = new Person("John", 30);
            Console.WriteLine($"Are person1 and person2 equal? {person1 == person2}");  // True (value-based equality)

            // Using with-expression to create a new record with updated properties, preserving immutability
            var updatedPerson = person1 with { Age = 31 };
            Console.WriteLine($"Updated Person: {updatedPerson.Name}, Age: {updatedPerson.Age}");

            // Demonstrating inheritance in records: Employee is derived from Person
            var employee1 = new Employee("Alice", 25, "Developer");
            Console.WriteLine($"Employee: {employee1.Name}, Age: {employee1.Age}, Position: {employee1.Position}");

            // Using with-expression to update an Employee's position
            var updatedEmployee = employee1 with { Position = "Senior Developer" };
            Console.WriteLine($"Updated Employee: {updatedEmployee.Name}, Age: {updatedEmployee.Age}, Position: {updatedEmployee.Position}");

            // Comparison with traditional Class - Record is immutable, while class is mutable
            var classPerson1 = new ClassPerson("John", 30);
            var classPerson2 = new ClassPerson("John", 30);
            Console.WriteLine($"Are classPerson1 and classPerson2 equal? {classPerson1 == classPerson2}");  // False (reference-based equality)

            classPerson1.Age = 31;  // Classes are mutable
            Console.WriteLine($"Updated Class Person: {classPerson1.Name}, Age: {classPerson1.Age}");

            // Demonstrating inheritance in class
            var classEmployee = new ClassEmployee("Alice", 25, "Developer");
            Console.WriteLine($"Class Employee: {classEmployee.Name}, Age: {classEmployee.Age}, Position: {classEmployee.Position}");

            // Modify inherited class property
            classEmployee.Position = "Senior Developer";
            Console.WriteLine($"Updated Class Employee: {classEmployee.Name}, Age: {classEmployee.Age}, Position: {classEmployee.Position}");
        }
    }

    // Record definition with inheritance
    public record Person(string Name, int Age);

    // Record definition with inheritance: Employee inherits from Person
    public record Employee(string Name, int Age, string Position) : Person(Name, Age);

    // Class definition for comparison
    public class ClassPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public ClassPerson(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Override equality to demonstrate reference-based comparison
        public override bool Equals(object obj)
        {
            return obj is ClassPerson person &&
                   Name == person.Name &&
                   Age == person.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age);
        }
    }

    // Class definition with inheritance: ClassEmployee inherits from ClassPerson
    public class ClassEmployee : ClassPerson
    {
        public string Position { get; set; }

        public ClassEmployee(string name, int age, string position) : base(name, age)
        {
            Position = position;
        }
    }
}
