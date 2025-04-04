using System;

namespace CSharp13
{
    /// <summary>
    /// Demonstrates the use of 'allows ref struct' in C# 13 for a generic class.
    /// This example shows how to restrict a generic type to accept only 'ref struct' types,
    /// which are stack-allocated and have special memory characteristics.
    /// It demonstrates the use of different duck types (Mallard and Peking) with a generic class.
    /// </summary>
    public static class AllowsRefStructDemo
    {
        public static void Run()
        {
              // Creating an instance of MallardDuck (which is a ref struct)
            var mallardDuck = new MallardDuck("Mallard", 5);

            // Creating an instance of PekingDuck (which is a ref struct)
            var pekingDuck = new PekingDuck("Peking", 3);

            // Using the GenericDuck class, which only accepts ref struct types
            var genericMallardDuck = new GenericDuck<MallardDuck>();
            genericMallardDuck.DisplayDuckInfo(mallardDuck);
            
            var genericPekingDuck = new GenericDuck<PekingDuck>();
            genericPekingDuck.DisplayDuckInfo(pekingDuck);
        }
    }

    /// <summary>
    /// A generic class that only accepts 'ref struct' types.
    /// This class represents a generic container for a 'ref struct' type.
    /// </summary>
    /// <typeparam name="T">The type of duck, constrained to be a 'ref struct'.</typeparam>
    public class GenericDuck<T> where T : IDuck, allows ref struct
    {
        public void DisplayDuckInfo(T duck)
        {
            Console.WriteLine($"Created a {typeof(T).Name} with a ref struct type.");
            Console.WriteLine($"Duck's name: {duck.Name}, Age: {duck.Age}");
        }
      public string GetTypeInfo()
      {
          return typeof(T).Name;
      }
    }

    /// <summary>
    /// A custom 'ref struct' that represents a MallardDuck.
    /// This type holds the name and age of the duck, demonstrating the use of 'ref struct'.
    /// </summary>
    public ref struct MallardDuck : IDuck
    {
        // Properties specific to MallardDuck
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor to initialize the MallardDuck with name and age
        public MallardDuck(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    /// <summary>
    /// A custom 'ref struct' that represents a PekingDuck.
    /// This type holds the name and age of the duck, demonstrating the use of 'ref struct'.
    /// </summary>
    public ref struct PekingDuck:IDuck
    {
        // Properties specific to PekingDuck
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor to initialize the PekingDuck with name and age
        public PekingDuck(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public interface IDuck
    {
        string Name { get; }
        int Age { get; }
    }
}
