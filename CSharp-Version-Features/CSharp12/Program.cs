using System.Runtime.CompilerServices;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("===== Running PrimaryConstructorsDemo =====");
Console.ResetColor();
PrimaryConstructorsDemo.Run();
Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("===== Running CollectionExpressionsDemo =====");
Console.ResetColor();
CollectionExpressionsDemo.Run();
Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("===== Running RefReadOnlyDemo =====");
Console.ResetColor();
RefReadOnlyDemo.Run();
Console.WriteLine("\n------------------------\n");


Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("===== Running DefaultLamdaParameteDemo =====");
Console.ResetColor();
DefaultLamdaParameteDemo.Run();
Console.WriteLine("\n------------------------\n");


Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("===== Running AliasAnyDemo =====");
Console.ResetColor();
AliasAnyDemo.Run();
Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Execution completed. Press any key to exit...");
Console.ResetColor();




