using CSharp9;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("===== Running RecordsDemo =====");
Console.ResetColor();
RecordsDemo.Run();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("===== Running InitOnlySettersDemo =====");
Console.ResetColor();
InitOnlySettersDemo.Run();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("===== Running PatternMatchingEnhancementsDemo =====");
Console.ResetColor();
PatternMatchingEnhancementsDemo.Run();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("===== Running PerformanceAndInteropDemo =====");
Console.ResetColor();
PerformanceAndInteropDemo.Run();


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("===== Running FitAndFinishDemo =====");
Console.ResetColor();
FitAndFinishDemo.Run();

Console.ReadKey();