namespace CSharp11;

// File-scoped class - This can only be used within this file.
file class Order
{
    public int Id { get; set; }
    public string Product { get; set; }
    public int Quantity { get; set; }
}

// File-scoped record - This can also only be used within this file.
file record Customer(int Id, string Name);

// Private class - This can only be used within the containing class.
public class OrderManager
{
    private class OrderDetails
    {
        public int OrderId { get; set; }
        public string Product { get; set; }
    }

    public void CreateOrder()
    {
        // Using file-scoped class within the same file
        var order = new Order { Id = 1, Product = "Laptop", Quantity = 2 };
        Console.WriteLine($"Order ID: {order.Id}, Product: {order.Product}, Quantity: {order.Quantity}");

        // Accessing the private OrderDetails class within the containing class
        var orderDetails = new OrderDetails { OrderId = 1, Product = "Laptop" };
        Console.WriteLine($"Order Details - ID: {orderDetails.OrderId}, Product: {orderDetails.Product}");
    }
}

// Summary:
// In C# 11, file-scoped types allow for the declaration of classes, structs, and records that are limited to the
// scope of the file they are declared in. This provides a cleaner way to organize code by limiting the visibility 
// of types to a specific file. These types are not accessible outside of the file, which can reduce unnecessary 
// clutter in global namespaces and improve encapsulation. 
//
// In contrast, private types (like `OrderDetails`) are limited to the scope of the containing type (in this case, 
// the `OrderManager` class). While both file-scoped types and private types are restricted in scope, file-scoped 
// types are not accessible even within the same assembly, whereas private types are only hidden within their 
// containing type.
public static class FileLocalTypesDemo
{
    public static void Run()
    {
        // 1. Defining a file-scoped type
        var order = new Order { Id = 1, Product = "Laptop", Quantity = 2 };

        // This is a simple file-scoped class used within this file only.
        // If you try to access Order outside this file, it will give an error.
        Console.WriteLine($"Order ID: {order.Id}, Product: {order.Product}, Quantity: {order.Quantity}");

        // 2. Example of file-scoped record (read-only reference types)
        var customer = new Customer(1, "John Doe");
        Console.WriteLine($"Customer: {customer.Name}, ID: {customer.Id}");

        // 3. Example of private class within a containing class
        var orderManager = new OrderManager();
        orderManager.CreateOrder();
    }
}
