namespace CSharp12
{
    // This class demonstrates the use of C# 12's primary constructors feature.
    // A primary constructor allows you to define class parameters directly in the class declaration,
    // which automatically creates properties and simplifies object initialization.
    public static class PrimaryConstructorsDemo
    {
        public static void Run()
        {
            // Example of creating objects with the Person class that has a primary constructor
            var person1 = new Person("Alice", 25);
            var person2 = new Person("Bob", 30);

            // Output the information of both people
            Console.WriteLine($"{person1.Name} is {person1.Age} years old.");
            Console.WriteLine($"{person2.Name} is {person2.Age} years old.");

            // Demonstrating method usage
            person1.CelebrateBirthday();
            person2.CelebrateBirthday();
            Console.WriteLine($"After a year, {person1.Name} is {person1.Age} years old.");
            Console.WriteLine($"After a year, {person2.Name} is {person2.Age} years old.");
        }
    }

    // The Person class uses a primary constructor, with Name and Age as its parameters.
    // This simplifies the creation of class instances by automatically creating properties
    // for the Name and Age parameters and assigning them in the constructor.
    public class Person(string name, int age)
    {
        // The parameters 'Name' and 'Age' automatically become properties of the class.
        // These can be used throughout the class as if they were regular fields.
        
        // You can use them to define methods, like 'CelebrateBirthday' below.
        public void CelebrateBirthday() => Age++;  // Increment age to simulate a birthday.

        // The primary constructor parameters are automatically converted into properties.
        public string Name { get; } = name;
        public int Age { get; set; } = age;
    }
}
