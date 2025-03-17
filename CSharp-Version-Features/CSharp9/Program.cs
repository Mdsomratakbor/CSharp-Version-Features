using CSharp9;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("===== Running RecordsDemo =====");
Console.ResetColor();
RecordsDemo.Run();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("===== Running InitOnlySettersDemo =====");
Console.ResetColor();
InitOnlySettersDemo.Run();




Console.ReadKey();