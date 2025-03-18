using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp9
{
    /// <summary>
    /// Demonstrates various "Fit and Finish" features introduced in C# 9.0.
    /// </summary>
    public static class FitAndFinishDemo
    {
        public static void Run()
        {
            Console.WriteLine("Running Fit and Finish Features Demo...\n");

            // 1. Target-Typed 'new' Expressions
            TargetTypedNew();

            // 2. Static Anonymous Functions
            StaticAnonymousFunctions();

            // 3. Target-Typed Conditional Expressions
            TargetTypedConditionalExpressions();

            // 4. Covariant Return Types
            CovariantReturnDemo();

            // 5. Extension GetEnumerator Support for foreach Loops
            ExtensionGetEnumeratorDemo();

            // 6. Lambda Discard Parameters
            LambdaDiscardParameters();

            // 7. Attributes on Local Functions
            AttributesOnLocalFunctions();
        }

        /// <summary>
        /// Demonstrates Target-Typed 'new' Expressions.
        /// This allows the compiler to infer the type when using 'new'.
        /// </summary>
        private static void TargetTypedNew()
        {
            Console.WriteLine("Target-Typed 'new' Expressions:");

            Person person = new("Alice", 25);  // No need to write "new Person(...)"
            Console.WriteLine($"Person Name: {person.Name}, Age: {person.Age}\n");
        }

        /// <summary>
        /// Demonstrates Static Anonymous Functions.
        /// </summary>
        private static void StaticAnonymousFunctions()
        {
            Console.WriteLine("Static Anonymous Functions:");

            Func<int, int, int> add = static (x, y) => x + y;
            Console.WriteLine($"Static Lambda Result: {add(5, 10)}\n");

            // Below line will cause an error because 'static' lambdas cannot capture outer variables.
            // int outer = 5;
            // Func<int, int> addOuter = static x => x + outer; // ERROR
        }

        /// <summary>
        /// Demonstrates Target-Typed Conditional Expressions.
        /// </summary>
        private static void TargetTypedConditionalExpressions()
        {
            Console.WriteLine("Target-Typed Conditional Expressions:");

            object result = true ? new PersonOne("Bob", 40) : new EmployeeOne("Manager", 50);
            Console.WriteLine($"Conditional Expression Result Type: {result.GetType().Name}\n");
        }

        /// <summary>
        /// Demonstrates Covariant Return Types.
        /// Allows overriding methods to return a more derived type.
        /// </summary>
        private static void CovariantReturnDemo()
        {
            Console.WriteLine("Covariant Return Types:");

            BaseFactory factory = new DerivedFactory();
            BaseEntity entity = factory.CreateEntity();
            Console.WriteLine($"Created Entity Type: {entity.GetType().Name}\n");
        }

        /// <summary>
        /// Demonstrates Extension GetEnumerator Support for foreach Loops.
        /// </summary>
        private static void ExtensionGetEnumeratorDemo()
        {
            Console.WriteLine("Extension GetEnumerator Support for foreach Loops:");

            var numbers = new CustomCollection();
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Demonstrates Lambda Discard Parameters.
        /// </summary>
        private static void LambdaDiscardParameters()
        {
            Console.WriteLine("Lambda Discard Parameters:");

            Action<int, int> log = (_, _) => Console.WriteLine("Ignoring parameters!");
            log(10, 20); // Discards parameters
            Console.WriteLine();
        }

        /// <summary>
        /// Demonstrates Attributes on Local Functions.
        /// </summary>
        private static void AttributesOnLocalFunctions()
        {
            Console.WriteLine("Attributes on Local Functions:");

            [Obsolete("This method is obsolete. Do not use.")]
            static void LocalMethod()
            {
                Console.WriteLine("Executing obsolete local function.\n");
            }

            LocalMethod();
        }
    }

    // Supporting Classes for Target-Typed 'new' Expressions
    public class PersonOne
    {
        public string Name { get; }
        public int Age { get; }

        public PersonOne(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class EmployeeOne
    {
        public string Role { get; }
        public int Age { get; }

        public EmployeeOne(string role, int age)
        {
            Role = role;
            Age = age;
        }
    }

    // Supporting Classes for Covariant Return Types
    public class BaseEntity { }

    public class DerivedEntity : BaseEntity { }

    public class BaseFactory
    {
        public virtual BaseEntity CreateEntity() => new BaseEntity();
    }

    public class DerivedFactory : BaseFactory
    {
        public override DerivedEntity CreateEntity() => new DerivedEntity();
    }

    // Custom Collection with Extension GetEnumerator Support
    public class CustomCollection : IEnumerable<int>
    {
        private readonly int[] _data = { 1, 2, 3, 4, 5 };

        public IEnumerator<int> GetEnumerator() => ((IEnumerable<int>)_data).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
