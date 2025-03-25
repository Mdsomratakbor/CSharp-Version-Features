namespace CSharp12;

    public static class RefReadOnlyDemo
    {
        // A List of integers (modifiable collection)
        static List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        static int age = 30;

        public static void Run()
        {
            // Print the initial value of age
            Console.WriteLine($"Age is: {age}");
            Test(ref age);  // Modify age using 'ref'

            // Call TestWithReadOnly, can't modify age
            TestWithReadOnly(ref age);

            // Pass the list by reference to a method using ref readonly
            // The list can be read but should not be modified inside the method.
            PrintList(ref numbers);
        }

        // A simple method to modify 'age' to show 'ref' behavior
        static void Test(ref int age)
        {
            Console.WriteLine($"Test: {age}");
            age++;  // Modify the age variable directly
        }

        // A method demonstrating 'ref readonly' with a primitive type
        static void TestWithReadOnly(ref readonly int age)
        {
            Console.WriteLine($"TestWithReadOnly: {age}");
            // Uncommenting the next line will cause a compile-time error:
            // age++;  // Cannot modify the variable when passed as 'ref readonly'
        }

        // A method that takes the list by reference using 'ref readonly'
        static void PrintList(ref readonly List<int> data)  // ref readonly to prevent modification
        {
            // We can read the list's contents but cannot modify the list itself
            Console.WriteLine("List contents: " + string.Join(", ", data));

            // Uncommenting the next line will cause a compile-time error:
            // data.Add(6);  // Error: Cannot modify a readonly reference

            // You can still access elements but cannot modify the list
            Console.WriteLine("Accessing the first element: " + data[0]);
        }
    }
