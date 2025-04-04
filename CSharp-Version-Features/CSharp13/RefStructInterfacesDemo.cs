using System;

namespace CSharp13
{
    // Define an interface with a method
    public interface IShape
    {
        void Draw();
    }

    // Define a ref struct that implements IShape
    public ref struct Circle
    {
        public double Radius { get; set; }

        // Implement the Draw method from IShape
        public void Draw()
        {
            Console.WriteLine($"Drawing a circle with radius {Radius}");
        }
    }

    public static class RefStructInterfacesDemo
    {
        public static void Run()
        {
            // Create a ref struct instance
            Circle circle = new Circle { Radius = 5.0 };

            // Use the ref struct method
            circle.Draw();
        }
    }
}

