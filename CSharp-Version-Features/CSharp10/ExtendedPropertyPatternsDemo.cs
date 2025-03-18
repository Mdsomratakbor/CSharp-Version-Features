namespace CSharp10;

/// <summary>
/// This class demonstrates the use of Extended Property Patterns introduced in C# 10.
/// The example uses Vehicle and Engine objects, demonstrating how extended property patterns simplify matching and accessing nested properties.
/// </summary>
public class ExtendedPropertyPatternsDemo
{
    /// <summary>
    /// This method demonstrates the usage of extended property patterns in C# 10.
    /// </summary>
    public static void Run()
    {
        // Creating instances of Vehicle with Engine properties
        var vehicle1 = new Vehicle("Car", new Engine("V8", 450));
        var vehicle2 = new Vehicle("Truck", new Engine("Diesel", 300));
        var vehicle3 = new Vehicle("Bike", null); // No engine for Bike

        // Using extended property patterns to check and access nested properties
        PrintEngineDetails(vehicle1); // Car with V8 engine will print the engine details.
        PrintEngineDetails(vehicle2); // Truck with Diesel engine will print the engine details.
        PrintEngineDetails(vehicle3); // No engine for Bike, will print "No engine information available."
    }

    /// <summary>
    /// Prints the engine details of the vehicle using extended property patterns.
    /// </summary>
    /// <param name="vehicle">Vehicle object</param>
    public static void PrintEngineDetails(Vehicle vehicle)
    {
        // Extended property pattern: matching if the vehicle has an Engine with a Model and HorsePower property.
        if (vehicle is Vehicle { Engine: { Model: var model, HorsePower: var horsePower } })
        {
            Console.WriteLine($"Engine Model: {model}, Horsepower: {horsePower} HP");
        }
        else
        {
            Console.WriteLine("No engine information available.");
        }
    }
}

/// <summary>
/// A simple Vehicle class with an Engine property for demonstration purposes.
/// </summary>
public class Vehicle
{
    public string Name { get; }
    public Engine Engine { get; }

    public Vehicle(string name, Engine engine)
    {
        Name = name;
        Engine = engine;
    }
}

/// <summary>
/// A simple Engine class with a Model and HorsePower property.
/// </summary>
public class Engine
{
    public string Model { get; }
    public int HorsePower { get; }

    public Engine(string model, int horsePower)
    {
        Model = model;
        HorsePower = horsePower;
    }
}
