namespace CSharp11
{
    // Summary:
    // In C# 11, when a struct is declared without a custom constructor, its fields are automatically initialized to their default values.
    // This applies to numeric fields (initialized to zero), boolean fields (initialized to false), and reference fields (initialized to null).
    // This behavior helps reduce boilerplate code and makes it easier to work with simple structs.
    internal static class AutoDefaultStructsDemo
    {
        // The Run method demonstrates how default initialization works for structs.
        public static void Run()
        {
            // 1. Define a struct without a constructor
            // The fields will automatically be initialized to their default values.
            var vehicle = new Vehicle();

            // 2. Output the default values of the struct's fields
            // Since no constructor is provided, all fields are initialized to their default values (e.g., 0 for int, null for string).
            Console.WriteLine($"Vehicle - Make: {vehicle.Make}, Model: {vehicle.Model}, Year: {vehicle.Year}, Mileage: {vehicle.Mileage}");

            // 3. Modifying some fields and displaying them
            vehicle.Make = "Toyota"; // Setting a string value
            vehicle.Model = "Corolla"; // Setting another string value
            vehicle.Year = 2021; // Setting an integer value
            vehicle.Mileage = 15000.5; // Setting a double value

            // 4. Output the modified values
            Console.WriteLine($"Updated Vehicle - Make: {vehicle.Make}, Model: {vehicle.Model}, Year: {vehicle.Year}, Mileage: {vehicle.Mileage}");
        }

        // A simple struct representing a Vehicle with various fields.
        // No constructor provided, so all fields will be initialized to their default values.
        public struct Vehicle
        {
            public string Make; // Defaults to null
            public string Model; // Defaults to null
            public int Year; // Defaults to 0
            public double Mileage; // Defaults to 0.0
        }
    }
}
