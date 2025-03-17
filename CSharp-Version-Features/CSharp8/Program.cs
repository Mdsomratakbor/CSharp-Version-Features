using CSharp8;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("===== Running ReadOnlyExampleDemo =====");
Console.ResetColor();
ReadOnlyExampleDemo.Run();

Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("===== Running DefaultInterfaceMethodsDemo =====");
Console.ResetColor();
DefaultInterfaceMethodsDemo.Run();


Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("===== Running PatternMatchingDemo =====");
Console.ResetColor();
PatternMatchingDemo.Run();


Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("===== Running UsingDeclarationDemo =====");
Console.ResetColor();
UsingDeclarationDemo.Run();


Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("===== Running StaticLocalFunctionDemo =====");
Console.ResetColor();
StaticLocalFunctionDemo.Run();

Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("===== Running DisposablerefstructsDemo =====");
Console.ResetColor();
DisposableRefStructDemo.Run();

Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("===== Running NullableReferenceDemo =====");
Console.ResetColor();
NullableReferenceDemo.Run();



Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("===== Running NullCoalescingAssignmentDemo =====");
Console.ResetColor();
NullCoalescingAssignmentDemo.Run();

Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("===== Running IndicesRangesDemo =====");
Console.ResetColor();
IndicesRangesDemo.Run();

Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("===== Running UnmanagedConstructedTypesDemo =====");
Console.ResetColor();
UnmanagedConstructedTypesDemo.Run();


Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("===== Running AsyncStreamDemo =====");
Console.ResetColor();
await AsyncStreamDemo.Run();

Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("===== Running StackallocInNestedExpressions =====");
Console.ResetColor();
StackallocInNestedExpressions.Run();

Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("===== Running EnhancedInterpolatedStringsDemo =====");
Console.ResetColor();
EnhancedInterpolatedStringsDemo.Run();

Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Execution completed. Press any key to exit...");
Console.ResetColor();

Console.ReadKey();