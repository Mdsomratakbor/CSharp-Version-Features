namespace CSharp11
{
    // Summary:
    // The `Product` class demonstrates the use of C# 11's `required` keyword, which ensures that certain properties
    // are initialized at the time of object creation. The `Name` and `Price` properties are marked as `required`,
    // meaning they must be set when creating a `Product` object. The `Description` property is optional, so it does not
    // need to be initialized. If the required properties are not provided, a compile-time error will occur.
    public class Product
    {
        // Required properties must be set during object creation
        public required string Name { get; set; }
        public required decimal Price { get; set; }
        public string? Description { get; set; }  // Optional property, no "required" keyword
    }

    public static class RequiredMembersDemo
    {
        // This method demonstrates the use of required members in C# 11
        public static void Run()
        {
            // 1. Valid initialization with required properties
            // When creating a Product object, both 'Name' and 'Price' are required and must be provided
            var product = new Product
            {
                Name = "Laptop",   // Required property
                Price = 1500.00M   // Required property
            };

            // Output the product details after valid initialization
            Console.WriteLine($"Product Name: {product.Name}, Price: {product.Price}");

            // 2. Attempting to create an object without required properties will give a compile-time error
            // Uncommenting the line below will cause a compile-time error because the 'Name' and 'Price' are required
            // var invalidProduct = new Product(); // This line will fail during compile-time due to missing required properties

            // 3. Optional properties do not require initialization
            // Here, the 'Description' is an optional property, so it is not necessary to initialize it when creating the object
            var productWithDescription = new Product
            {
                Name = "Smartphone", // Required property
                Price = 799.99M,     // Required property
                Description = "Latest model" // Optional property
            };

            // Output the product details including the optional Description property
            Console.WriteLine($"Product Name: {productWithDescription.Name}, Price: {productWithDescription.Price}, Description: {productWithDescription.Description}");
        }
    }
}
