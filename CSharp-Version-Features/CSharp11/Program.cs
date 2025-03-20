Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("===== Running RawStringLiteralsDemo =====");
Console.ResetColor();
RawStringLiteralsDemo.Run();
Console.WriteLine("\n------------------------\n");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("===== Running UTF8StringLiteralsDemo =====");
Console.ResetColor();
UTF8StringLiteralsDemo.Run();


Console.WriteLine("\n------------------------\n");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("===== Running StringInterpolationNewLineDemo =====");
Console.ResetColor();
StringInterpolationNewLineDemo.Run();



Console.WriteLine("\n------------------------\n");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("===== Running ListPatternDemo =====");
Console.ResetColor();
ListPatternDemo.Run();

Console.WriteLine("\n------------------------\n");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("===== Running FileLocalTypesDemo =====");
Console.ResetColor();
FileLocalTypesDemo.Run();


Console.WriteLine("\n------------------------\n");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("===== Running RequiredMembersDemo =====");
Console.ResetColor();
RequiredMembersDemo.Run();

Console.WriteLine("\n------------------------\n");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Execution completed. Press any key to exit...");
Console.ResetColor();




Console.ReadKey();