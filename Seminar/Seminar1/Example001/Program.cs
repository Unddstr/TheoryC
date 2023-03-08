Console.Clear();
Console.Write("Введите 1-е число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Result: ");
Console.WriteLine(n+m);
Console.WriteLine($"Result: {n} + {m} = {n + m} ");