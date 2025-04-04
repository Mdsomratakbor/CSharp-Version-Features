using CSharp13;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("===== Running ParamsCollectionsDemo =====");
Console.ResetColor();
ParamsCollectionsDemo.Run();
Console.WriteLine("\n------------------------\n");


Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("===== Running NewEscapeSequenceDemo =====");
Console.ResetColor();
NewEscapeSequenceDemo.Run();
Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("===== Running ImplicitIndexAccessDemo =====");
Console.ResetColor();
ImplicitIndexAccessDemo.Run();
Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("===== Running MorePartialMembersDemo =====");
Console.ResetColor();
MorePartialMembersDemo.Run();
Console.WriteLine("\n------------------------\n");


Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("===== Running NewLockObjectDemo =====");
Console.ResetColor();
await NewLockObjectDemo.Run();
Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("===== Running RefInIteratorsAndAsyncMethodsDemo =====");
Console.ResetColor();
await RefInIteratorsAndAsyncMethodsDemo.Run();
Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Execution completed.");
Console.ResetColor();